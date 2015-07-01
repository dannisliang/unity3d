import bpy
import sys

argv = sys.argv[sys.argv.index("--") + 1:]

print("-----------------------")
print()
print("-----------------------")

#bpy.data.scenes[0].file_format = 'AVI_JPEG'

naoRender = ["","POSE-NEUTRA", "_configMaoDir", "_configMaoEsq", "_configMaoDir.001", "_configMaoDir.002", 
"_configMaoEsq.001", "CDA:ObIpo.001", "_orientacaoDir", "_orientacaoEsq", "_pontoArticula_Dir",
"_pontoArticula_Esq"] 

def setRender(a):
	bpy.data.objects['Armature.001'].animation_data.action = a
	bpy.context.scene.frame_end = a.frame_range[-1]
	print(argv[0])
	bpy.context.scene.render.filepath = (bpy.path.abspath('//')+ argv[0][:-5]+ '/' + a.name)
#	bpy.ops.render.render(animation=True)

for act in bpy.data.actions:
	if not (act.name in naoRender):
		print(act.name)
		setRender(act)
		bpy.ops.render.render(animation=True)
	
print("-----------------------")	
