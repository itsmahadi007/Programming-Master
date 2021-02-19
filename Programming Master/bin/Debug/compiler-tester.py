import os
import re

#PATH = "F:\\Project\\Nahid\\OfflineJudge\\extra\\offline-judge-master\\test"
f=open('problemNo.txt','r')
probPath=f.read()
f.close()
PATH =os.getcwd()+'\\src\\problem_solution\\'+ probPath
execheck= PATH + '\\a.exe'

def findFile(): #geting all the file in dic and geting there extention 
	
	for root, dirs, files in os.walk(PATH):
		for file in files:
			pos = file.count('.')
			if pos == 1:
				pos = file.index('.')
				lang = file[pos+1:]
				if lang == 'c' or lang == 'cpp' or lang == 'java':
					return (file,pos,lang)


def langCompiler(file,pos,lang):        # deciding the file type and runfile type
	
	classfile = ''
	runfile = ''
	
	if lang== 'java':
		classfile = 'javac '+ file
		runime = 'java ' +file[:pos] #name of class and file should be same

	if lang == 'cpp':
		classfile = 'g++ -o '+ file[:pos] + ' '  + file   
		#print("from lang compiler file " +file[:pos])
		#print("from lang compiler file " +file) #print will be a.cpp
		runfile = file[:pos] +'.exe'
		#print("from lang compiler file " +runfile)

	if lang == 'c':
		classfile = 'gcc -o ' + file[:pos] + ' ' + file
		runfile = file[:pos] +'.exe'

	#print()
	return (classfile,runfile)


def compileFile(classfile): #creating exe file  
	
	os.system(classfile)

def runFile(runfile):   
	
	i = 1
	#print(os.listdir(PATH))
	#print()
	for file in os.listdir(PATH):
		#print(str(i))
		if file == str(i): 
			os.system(runfile + ' < ' + str(i) + ' > ' + 'output_' + str(i))
			i = i + 1
	#print()
	
	#print(os.listdir(PATH))


def removeObject(file,lang,pos):
	if lang == 'c' or lang == 'cpp':
		for files in os.listdir(PATH):
			if files == file[:pos]:
				#print(file[:pos])
				#print("remnove object")
				os.remove(file[:pos])
	elif lang == 'java':
		for files in os.listdir(PATH):
			if files == file[:pos] + '.class':
				os.remove(file[:pos] + '.class')
				

def removeWhiteSpaces(data):
	return data.strip()


def compareOutputs():
	
	i = 1 
	passed = 1
	for files in os.listdir(PATH):
		if files == 'output_' + str(i):
			f = open('output_' + str(i) , 'r')
			data = f.read()
			
			os.chdir(PATH + '/outputs')
			g = open(str(i),'r')
			datacmp = g.read()
			
			if removeWhiteSpaces(data) == removeWhiteSpaces(datacmp):
				passed = passed + 1
			
			g.close()
			os.chdir(PATH)
			f.close()
			i = i + 1
	#open('finaloutput.txt','w').close()

	if passed == i :
		#print("\nAll Test Cases Passed")
		q=open('finaloutput.txt','w')
		q.write('Accepted')
		q.close()
	else:
		q=open('finaloutput.txt','w')
		q.write('Oops! you faild'+str(i-passed)+' Test Cases')
		q.close()
	    #print("\nOops! You failed " + str(i-passed) + " Test Cases")
def clearOutput():
	i=1
	for files in os.listdir(PATH):
		if files == 'output_'+str(i):
			open(files,'w').close()
			i=i+1

def check():
	if  os.path.isfile(execheck):
		os.remove(execheck)
		
def checkexe():
	if os.path.isfile(execheck):
		compareOutputs()
	else:
		os.chdir(PATH)
		q=open('finaloutput.txt','w')
		q.write('Compilation Error Check your code again')
		q.close()
		exit(0)


if __name__ == '__main__':
	file, pos, lang = findFile()
	classfile, runfile = langCompiler(file,pos,lang)

	pt=os.getcwd() + '\\test'+'\\finaloutput.txt'
	open(pt,'w').close()
	os.chdir(PATH)
	
	check()
	
	try:
		compileFile(classfile)
	except:
		#print("Compilation Error")
		q=open('finaloutput.txt','w')
		q.write('Compilation Error')
		exit(0)
	
	runFile(runfile)
	removeObject(file,lang,pos)

	checkexe()
	clearOutput()
