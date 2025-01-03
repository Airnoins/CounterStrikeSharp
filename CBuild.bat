git submodule update --init --recursive

mkdir build
cd build

cmake ..

cmake --build . --config Debug

xcopy "addons" "..\..\CBuild\addons" /E /I /H /C /Y

pause
