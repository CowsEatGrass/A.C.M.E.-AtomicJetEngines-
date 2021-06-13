:START
@echo off
ECHO   _______________________________________
ECHO  [                                       ]
ECHO  [   A.C.M.E. Measurement Interpreter    ]
ECHO  [   Technical Support 1(309)273-8047    ]
ECHO  [_______________________________________]
ECHO     ^|^/
ECHO     ^'
set fileToRead=C:\A.C.M.E\AtomicJetEngines\PlasmaChromatograph_Q-36\WinCMD\MarsDataRaw.csv
Set fileToWrite=C:\A.C.M.E\AtomicJetEngines\PlasmaChromatograph_Q-36\WinCMD\EarthDataRaw.ini

::====================================================
:: Check if file exists
::----------------------------------------------------
if not exist %fileToRead% (
echo  %fileToRead% could not be found...
TIMEOUT 10
cls
goto :START
)

::====================================================
:: Read File, LINE BY LINE, into myArray
::----------------------------------------------------
setlocal enabledelayedexpansion
set count=0
for /f "tokens=*" %%x in (%fileToRead%) do (
    set /a count+=1
    set myArray[!count!]=%%x
)

::====================================================
:: Parse Line 4
::----------------------------------------------------
set line4=%myArray[4]%
for /f "tokens=1,2 delims=," %%a in ("%line4%") do (
  set colA=%%a
  set colB=%%b
)

::====================================================
:: Evaluate Sample Location
::----------------------------------------------------
set locTurbineHP=NAN
set locTurbineLP=NAN
set locNozzle=NAN
if %colB%=="TurbineHP" set locTurbineHP=1
if %colB%=="TurbineLP" set locTurbineLP=1
if %colB%=="Nozzle" set locNozzle=1

::====================================================
:: Output File
::----------------------------------------------------
type nul > %fileToWrite%
echo [MeasureLoc] > %fileToWrite%
echo TurbineHP=%locTurbineHP% >> %fileToWrite%
echo TurbineLP=%locTurbineLP% >> %fileToWrite%
echo Nozzle=%locNozzle% >> %fileToWrite%
echo.   >> %fileToWrite%
echo [TechSupport] >> %fileToWrite%
echo Contact=Philip_Stubbs >> %fileToWrite%
echo Phone=1(309)273-8047 >> %fileToWrite%

::====================================================
:: Display Current Values for 10s then loop
::----------------------------------------------------
echo  READ: %fileToRead%
echo  WRITE: %fileToWrite%
ECHO.
echo  Sample Location Name: %colB%
TIMEOUT 10
cls
goto :START

pause