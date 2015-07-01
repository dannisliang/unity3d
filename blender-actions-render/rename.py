# Renomear arquivos .avi
# removendo numeros dos frames.

import os

for l in os.listdir('.'):
	if(l[-4:] == '.avi'):
		os.rename(l, l[:-14].upper()+'.avi' )
		
		
		