set selfpath=%~dp0

cd %selfpath%

git submodule update --init --recursive

mkdir build
cd build

cmake ..

cmake --build . --config Release

xcopy "Release\counterstrikesharp.dll" "..\..\ambuild\addons\counterstrikesharp\bin\win64\" /Y
xcopy "addons" "..\..\ambuild\addons" /E /I /H /C /Y

pause
