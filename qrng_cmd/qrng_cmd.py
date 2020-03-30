#!/usr/bin/python

import sys, getopt
import glob
import subprocess
import datetime

def addCol (newLine, randNB, colLoop, nbcolumns, outfile):
    if colLoop == 0:
        outfile.write(newLine+"\n")
        return randNB[:-1], nbcolumns - 1
    else:
        if newLine == "":
            newLine = randNB[:-1]
        else:
            newLine = newLine + ";" + randNB[:-1]
        colLoop = colLoop - 1
        return newLine, colLoop


def columnCreation(inputFile, outputfile, nbcolumns):
    inputFiles = inputFile + '*.*'
    colLoop = nbcolumns
    newLine = ""
    outfile = open(outputfile, "a")

    for filePath in glob.glob(inputFiles):
        print("File being processed : ", filePath)
        nbLinesRead = 0
        # Ouvrir le fichier en lecture seule
        file = open(filePath, "r")
        while True:
            # utilisez readline() pour lire la ligne suivante
            randNB = file.readline()
            if randNB:
                nbLinesRead += 1
                newLine, colLoop = addCol(newLine, randNB, colLoop, nbcolumns, outfile)
            else:
                break
        file.close()
        print(" Lines read ", nbLinesRead)
    #on vide le buffer
    outfile.write(newLine+"\n")
    outfile.close()

def qrnGenerator(inputfiles, nbfiles, samples):
    for i in range(0,nbfiles):
        outfile = inputfiles + "." + str(i) + ".csv"
        print('Generate file ', outfile)
        cmdLine = "c:\\Program Files (x86)\\ID Quantique SA\\EasyQuantis\\EasyQuantis.exe -u 0 -f "+ outfile + " -n " + str(samples)
        subprocess.call(cmdLine)

def usage():
    print('qrng_cmd.py -i <inputfile> -o <outputfile> -c <# of columns> -g -s <# of samples>' )

def main(argv):
    inputfile = ''
    outputfile = ''
    nbcolumns = 0
    qrng = False
    samples = 0
    nbfiles = 0
    try:
        opts, args = getopt.getopt(argv,"hi:o:c:gs:f:",["ifile=","ofile=","columns=","samples=", "nfiles="])
    except getopt.GetoptError:
        usage()
        sys.exit(2)
    for opt, arg in opts:
        if opt == '-h':
            usage()
            sys.exit()
        elif opt in ("-i", "--ifile"):
            inputfile = arg
        elif opt in ("-o", "--ofile"):
            outputfile = arg
        elif opt in ("-c", "--columns"):
            nbcolumns = int(arg)
        elif opt in ("-f", "--nfiles"):
            nbfiles = int(arg)
        elif opt == "-g":
            qrng = True
        elif opt in ("-s", "--samples"):
            samples = int(arg)
    if(((inputfile == '' or outputfile == '' or nbcolumns == 0) and (qrng == False)) or (qrng and (samples == 0 or (inputfile == '' or outputfile == '' or nbcolumns == 0)))):
        usage()
    else:
        print('Input file is ', inputfile)
        print('Output file is ', outputfile)
        print('# of columns in output file ', nbcolumns)
        startTime = datetime.datetime.now()
        print ('starting process time ',startTime)
        if(qrng):
            print('Generation random numbers with Quantis ')
            print('# of files generated ', nbfiles)
            print('# of random numbers per files) ', samples)
            qrnGenerator(inputfile, nbfiles, samples)
            print('Generation process time ',datetime.datetime.now() - startTime)
        if((qrng and outputfile != '') or qrng == False):
            consolTime = datetime.datetime.now()
            columnCreation(inputfile, outputfile, nbcolumns)
            print('consolidation process time ', datetime.datetime.now() - consolTime)
        print('Total process time ', datetime.datetime.now() - startTime)

if __name__ == "__main__":
   main(sys.argv[1:])

