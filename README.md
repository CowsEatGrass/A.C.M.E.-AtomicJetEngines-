![Logo](https://user-images.githubusercontent.com/35185358/121840414-cad9bb80-cca1-11eb-9ec8-6e4db90699e2.PNG)
# A.C.M.E.-AtomicJetEngines-
**A.C.M.E. Atomic Jet Engines:** Eludium Q-36 Plasma Chromatography Interpreter

**__Purpose__** 

	This is a fun project intended to explore different Discrete & Multi-Platform coding mediums:
	1) Windows CMD Line / PowerShell / Linux Bash
	2) C# .NET / C# Core 
	3) Julia / Python 
	4) C / Pascal / Fortran
	5) Kotlin / Lua / Ruby
	6) LabView 

**__Story__** 

	A.C.M.E. Research & Development (on Mars) is testing Eludium Q-36 as a fuel for their Atomic Jet Engines.
	A.C.M.E. Simulation & Safety (on Earth) runs some of this testing remotely.

**__Problem One__** 

	The A.C.M.E. Plasma Chromatograph on Mars outputs the Measurement Sample Locations as strings.
	However, the A.C.M.E. Simulation In Loop software is not capable of ingesting Data Strings.

**__Problem Two__** 

	The A.C.M.E. Plasma Chromatograph on Mars runs on Local Solar Time (LST) on Mars.
	However, A.C.M.E. Simulation in Loop software runs on Universal Standard Time (UST) on Earth.

**__Goal__** 

	Write a simple Measurement Interpreter to convert the A.C.M.E. Plasma Chromatograph's CSV output file
	"MarsDataRaw.csv" to an INI file "EarthDataRaw.ini" for ingestion into A.C.M.E Simulation & Loop software.
 
**__Example CSV__** 

	SampleName,"Atomic Jet Engine"
	MethodName,"Chromatograph_Q-36"
	UserName,"Marvin T. Martian"
	Comments,"TurbineHP" **OR** "TurbineLP" **OR** "Nozzle"
	LocalSolarTime,"75/123 12:34:56"
	SettingsFile,"Eludium Q-36.cnfg"
	Instrument,"123456789"
	RawTotalMolePct,1.4119
	==========,==========,==========,==========,==========,==========
	Number,Component,Ret.Time,Peak Area,Normalized%
	1,"Eludium Q-36",38.8000,80795.3700,100.0000
	==========,==========,==========,==========,==========,==========
	Year,SolarLongitude,Hour,Minute,Second
	"75","123","12","34","56"  

**__Technical References__** 

	https://www.planetary.org/articles/mars-calendar
	https://en.wikipedia.org/wiki/Timekeeping_on_Mars#Martian_calendars
	https://en.wikipedia.org/wiki/Julian_day
	https://en.wikipedia.org/wiki/Year#Besselian_year
	https://en.wikipedia.org/wiki/Universal_Time  

**Contributors:** 

	Philip D. Stubbs, Test Engineer & Software Support Lead
	Marvin T. Martian, Chief Engineer & Technical Design Lead
	Wylie E. Coyote, Safety Engineer & Simulation Analyst  

