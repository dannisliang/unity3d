#    SCRIPT PARA CRIAR ARQUIVO
#    COM OS NOMES DOS ACTIONS
#

import bpy


f = open('lista', 'w')

for a in list(bpy.data.actions):
	f.write(a.name + "\n")
	
	
f.close()
