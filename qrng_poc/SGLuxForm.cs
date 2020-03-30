using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using idQ;
using System.IO;

namespace SGLux
{
  public partial class SGLuxForm : Form
  {
    private QuantisDeviceType deviceType = QuantisDeviceType.QUANTIS_DEVICE_PCI;
    private uint deviceNumber = 0;

    public SGLuxForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Display library version
      textBoxInfo.Text = string.Concat("Using Quantis library version ", Quantis.GetLibVersion(), Environment.NewLine);
      
      // Count Quantis devices
      int countPci = Quantis.Count(QuantisDeviceType.QUANTIS_DEVICE_PCI);
      int countUsb = Quantis.Count(QuantisDeviceType.QUANTIS_DEVICE_USB);
      textBoxInfo.Text += string.Concat("Found: ", Environment.NewLine);
      textBoxInfo.Text += string.Concat("   - ", countPci, " Quantis PCI/PCIe", Environment.NewLine);
      textBoxInfo.Text += string.Concat("   - ", countUsb, " Quantis USB", Environment.NewLine);
      textBoxInfo.Text += Environment.NewLine;
      
      // Select first available device
      // Note that in a real application, it would be better to let the user choose the device he wants to use...
      if (countPci > 0)
      {
        deviceType = QuantisDeviceType.QUANTIS_DEVICE_PCI;
        deviceNumber = 0;
        textBoxInfo.Text += string.Concat("Using PCI card #", deviceNumber, Environment.NewLine);
      }
      else if (countUsb > 0)
      {
        deviceType = QuantisDeviceType.QUANTIS_DEVICE_USB;
        deviceNumber = 0;
        textBoxInfo.Text += string.Concat("Using USB device #", deviceNumber, Environment.NewLine);
      }
      else
      {
        textBoxInfo.Text = string.Concat("ERROR: No Quantis found!", Environment.NewLine);
        groupBoxData.Enabled = false;
        return;
      }

      // Display information about used device
      try
      {
        Quantis quantis = new Quantis(deviceType, deviceNumber);
        textBoxInfo.Text += string.Concat("   core version:  ", quantis.GetBoardVersion().ToString("X"), Environment.NewLine);
        textBoxInfo.Text += string.Concat("   serial number: ", quantis.GetSerialNumber(), Environment.NewLine);
        textBoxInfo.Text += string.Concat("   manufacturer: ", quantis.GetManufacturer(), Environment.NewLine);
        textBoxInfo.Text += string.Concat("   Data rate:", quantis.GetModulesDataRate(), Environment.NewLine);
      }
      catch(QuantisException ex)
      {
        textBoxInfo.Text += string.Concat("ERROR while retrieving Quantis information: ", ex.Message, Environment.NewLine);
      }
    }

    private void buttonGenerate_Click(object sender, EventArgs e)
    {
      try
      {
        textBoxBuffer.Text += string.Concat("Initialization", DateTime.Now.ToString(), Environment.NewLine);
        Quantis quantis = new Quantis(deviceType, deviceNumber);
        Double randD = 0.0;
        uint nbLoop = 0;
        string fileName = "";

        // Read random data
        uint nbUnderlyings = Convert.ToUInt32(numericUpDown2.Value);
        
        if (checkBoxFiles.Checked) {
          textBoxBuffer.Text += string.Concat("Start generating Multi files", DateTime.Now.ToString(), Environment.NewLine);
          for (uint nbFiles=0; nbFiles < nbUnderlyings; nbFiles++)
          {
            Application.DoEvents();

            fileName = string.Concat(textBoxFileName.Text, "_", Convert.ToString(nbFiles),".csv"); 

            StreamWriter monStreamWriter = new StreamWriter(fileName); 

            // Read random data
            nbLoop = Convert.ToUInt32(numericUpDown1.Value);
          
            for (uint b=0; b<nbLoop; b++)
            {
              //double randD = quantis.ReadDouble (0.0, 1.0);
              randD = quantis.ReadDouble();
              monStreamWriter.WriteLine(randD);
              Application.DoEvents();
            }

            // Fermeture du StreamWriter, très important pour libérer la ressource
            monStreamWriter.Close(); 
          }
        }
        else
        {
          textBoxBuffer.Text += string.Concat("Start generating Multi columns", DateTime.Now.ToString(), Environment.NewLine);
          fileName = string.Concat(textBoxFileName.Text, ".csv"); 

            StreamWriter monStreamWriter = new StreamWriter(fileName); 

            // Read random data
            nbLoop = Convert.ToUInt32(numericUpDown1.Value);
            String rawRand = "";
            for (uint b=0; b<nbLoop; b++)
            {
              Application.DoEvents();
              rawRand = "";
              for (uint nbColumns=0; nbColumns < nbUnderlyings; nbColumns++){
                //double randD = quantis.ReadDouble (0.0, 1.0);
                randD = quantis.ReadDouble();
                if (nbColumns > 0) rawRand = string.Concat(rawRand,";");
                rawRand = string.Concat(rawRand,Convert.ToString(randD));
              }             
              monStreamWriter.WriteLine(rawRand);
            }
            // Fermeture du StreamWriter, très important pour libérer la ressource
            monStreamWriter.Close();
        }
        textBoxBuffer.Text += string.Concat(Environment.NewLine, "Files generated", DateTime.Now.ToString(), Environment.NewLine);
      }
      catch (QuantisException ex)
      {
        textBoxBuffer.Text += string.Concat("ERROR while retrieving random data: ", ex.Message, Environment.NewLine);
      }
    }
  }
}
