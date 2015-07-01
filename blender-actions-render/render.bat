ECHO OFF

FOR %%f IN (*.blend) DO "C:\Program Files\Blender Foundation\Blender\blender" -b "%%f" -P "renderACTS.py" -- "%%f"


