/*************************************/
/*  BEGIN POPULATION INSERT SCRIPTS  */
/*************************************/

USE PCBuilder
GO

/*********** BASE  LENGTHS ***********/
--RamTimings		CHAR(14)			<< FORMAT OF XX-XX-XX-XX-XT
--Brand				VARCHAR(10)			|--FirstName		VARCHAR(50)
--Model				VARCHAR(25)			|--LastName			VARCHAR(50)
--Socket			VARCHAR(25)			|--Address			VARCHAR(50)
--ProductLaneName	VARCHAR(25)			|--City				VARCHAR(50)
--BestUse			VARCHAR(50)			|--StateCode		CHAR(2)
--Price				DECIMAL(7,2)		|--Zip				VARCHAR(9)
--GpuLength			CHAR(1)				|--LocalPhone		VARCHAR(10)
--Chipset			VARCHAR(25)			|--Email			VARCHAR(100)
--FormFactor		VARCHAR(10)			|--Username			VARCHAR(50)
--Efficiency		VARCHAR(10)			|--Password			VARCHAR(50)
--StorageType		VARCHAR(5)			|--RoleName			VARCHAR(50)
--OpticalType		VARCHAR(10)			|--RoleDescription	VARCHAR(MAX)


/*************************************/
/*            CPU  INSERT            */
/*************************************/
INSERT INTO CPU 
VALUES
 ('Intel'	,'i7-5960x'		,'8' ,'1' ,'3.0' ,'1' ,'2011v3'	,'Haswell-E'	,'15991'	,'Rendering', '140'	,'1049.99')
,('Intel'	,'i7-5930k'		,'6' ,'1' ,'3.5' ,'1' ,'2011v3'	,'Haswell-E'	,'13644'	,'Rendering', '140'	,'579.99' )
,('Intel'	,'i7-5820k'		,'6' ,'1' ,'3.3' ,'1' ,'2011v3'	,'Haswell-E'	,'13003'	,'Rendering', '140'	,'389.99' )
,('Intel'	,'i7-4790k'		,'4' ,'1' ,'4.0' ,'1' ,'1150'	,'Devils Canyon','11226'	,'Rendering', '84'	,'339.99' )
,('Intel'	,'i7-6700k'		,'4' ,'1' ,'4.0' ,'1' ,'1151'	,'Skylake'		,'11013'	,'Rendering', '95'	,'419.99' )
,('AMD'		,'FX-9590'		,'8' ,'1' ,'4.7' ,'1' ,'AM3+'	,'Vishera'		,'10267'	,'Rendering', '220'	,'309.99' )
,('Intel'	,'i7-4790'		,'4' ,'1' ,'3.6' ,'0' ,'1150'	,'Devils Canyon','10028'	,'Rendering', '84'	,'309.99' )
,('Intel'	,'i7-6700'		,'4' ,'1' ,'3.4' ,'0' ,'1151'	,'Skylake'		,'9958'		,'Rendering', '65'	,'349.99' )
,('Intel'	,'i7-4770'		,'4' ,'1' ,'3.4' ,'0' ,'1150'	,'Haswell'		,'9842'		,'Rendering', '84'	,'304.99' )
,('AMD'		,'FX-9370'		,'8' ,'0' ,'4.4' ,'1' ,'AM3+'	,'Vishera'		,'9533'		,'Rendering', '220'	,'179.99' )
,('Intel'	,'i7-4770S'		,'4' ,'1' ,'3.1' ,'0' ,'1160'	,'Haswell'		,'9332'		,'Gaming'	, '65'	,'305.99' )
,('AMD'		,'FX-8350'		,'8' ,'0' ,'4.0' ,'1' ,'AM3+'	,'Vishera'		,'8964'		,'Gaming'	, '125'	,'179.99' )
,('Intel'	,'i5-6600k'		,'4' ,'0' ,'3.5' ,'1' ,'1151'	,'Skylake'		,'7811'		,'Gaming'	, '91'	,'269.99' )
,('Intel'	,'i5-4670k'		,'4' ,'0' ,'3.4' ,'1' ,'1150'	,'Haswell'		,'7631'		,'Gaming'	, '84'	,'254.99' )
,('Intel'	,'i5-4590'		,'4' ,'0' ,'3.3' ,'0' ,'1150'	,'Haswell'		,'7218'		,'Gaming'	, '84'	,'199.99' )
,('Intel'	,'i5-6500'		,'4' ,'0' ,'3.2' ,'0' ,'1151'	,'Skylake'		,'7057'		,'Gaming'	, '65'	,'204.99' )
,('AMD'		,'FX-6350'		,'6' ,'0' ,'3.9' ,'1' ,'AM3+'	,'Vishera'		,'6984'		,'Gaming'	, '125'	,'129.99' )
,('Intel'	,'i5-4460'		,'4' ,'0' ,'3.2' ,'0' ,'1150'	,'Haswell'		,'6632'		,'Gaming'	, '84'	,'189.99' )
,('Intel'	,'i5-6400'		,'4' ,'0' ,'2.7' ,'0' ,'1151'	,'Skylake'		,'6471'		,'Gaming'	, '65'	,'170.99' )
,('AMD'		,'FX-6300'		,'6' ,'0' ,'3.5' ,'1' ,'AM3+'	,'Vishera'		,'6347'		,'Gaming'	, '95'	,'109.99' )
,('AMD'		,'AthlonX4 860K','4' ,'0' ,'3.7' ,'1' ,'FM2+'	,'Kaveri'		,'5609'		,'Gaming'	, '95'	,'70.99'  )
,('AMD'		,'A10-7850K'	,'2' ,'1' ,'3.7' ,'1' ,'FM2+'	,'Kaveri'		,'5575'		,'Gaming'	, '95'	,'129.99' )
,('AMD'		,'A10-7870K'	,'2' ,'1' ,'3.9' ,'1' ,'FM2+'	,'Kaveri'		,'5500'		,'Gaming'	, '95'	,'139.99' )
,('Intel'	,'i3-4370'		,'2' ,'1' ,'3.8' ,'0' ,'1150'	,'Haswell'		,'5547'		,'Software'	, '54'	,'146.99' )
,('Intel'	,'i3-6100'		,'2' ,'1' ,'3.7' ,'0' ,'1151'	,'Skylake'		,'5526'		,'Software'	, '51'	,'129.99' )
,('AMD'		,'A8-7650K'		,'2' ,'1' ,'3.3' ,'1' ,'FM2+'	,'Kaveri'		,'5172'		,'Software'	, '65'	,'99.99'  )
,('Intel'	,'i3-4170'		,'2' ,'1' ,'3.7' ,'0' ,'1150'	,'Haswell'		,'5171'		,'Software'	, '54'	,'124.99' )
,('AMD'		,'FX-4350'		,'4' ,'0' ,'4.2' ,'1' ,'AM3+'	,'Vishera'		,'5210'		,'Office'	, '125'	,'89.99'  )
,('Intel'	,'g3258'		,'2' ,'0' ,'3.2' ,'1' ,'1150'	,'Haswell'		,'4002'		,'Office'	, '53'	,'69.99'  )
,('Intel'	,'g4500'		,'2' ,'0' ,'3.5' ,'0' ,'1151'	,'Skylake'		,'3424'		,'Basic'	, '51'	,'89.99'  )
,('Intel'	,'g1850'		,'2' ,'0' ,'2.9' ,'0' ,'1150'	,'Haswell'		,'2978'		,'Basic'	, '54'	,'54.99'  )
,('Intel'	,'g1820'		,'2' ,'0' ,'2.7' ,'0' ,'1150'	,'Haswell'		,'2850'		,'Basic'	, '53'	,'39.99'  )
,('AMD'		,'Athlon 5150'	,'4' ,'0' ,'1.6' ,'0' ,'AM1'	,'Kabini'		,'2046'		,'Basic'	, '25'	,'40.99'  )
,('AMD'		,'Athlon 5350'	,'4' ,'0' ,'2.1' ,'0' ,'AM1'	,'Kabini'		,'2587'		,'Basic'	, '25'	,'49.99'  )

--,('','','','','','','','','','','','')
--Brand,Model,Cores,HyperThreaded,ClockSpeed,Unlocked,Socket,ProductLineName,BenchmarkScore,BestUse,PowerRequirement,Price
GO


/*************************************/
/*            GPU  INSERT            */
/*************************************/
INSERT INTO GPU
VALUES
 ('nVidia'	,'GTX 980Ti','1076'	,'Maxwell'		,'11516' ,'Rendering' ,'6'  ,'8' ,'8' ,'0' ,'250' ,'L' ,'649.99')
,('nVidia'	,'GTX 980'	,'1126'	,'Maxwell'		,'9759'	 ,'Rendering' ,'4'  ,'8' ,'8' ,'0' ,'165' ,'L' ,'509.99')
,('nVidia'	,'GTX 970'	,'1050'	,'Maxwell'		,'8657'	 ,'Gaming' 	  ,'4'  ,'6' ,'6' ,'0' ,'145' ,'L' ,'329.99')
,('AMD'		,'R9 Fury'  ,'1050'	,'Fiji XT'		,'8237'	 ,'Rendering' ,'4'  ,'8' ,'8' ,'0' ,'275' ,'L' ,'589.99')
,('AMD'		,'R9 390x'	,'1000'	,'Grenada XT'	,'7063'	 ,'Rendering' ,'4'  ,'8' ,'8' ,'0' ,'290' ,'L' ,'409.99')
,('AMD'		,'R9 390'	,'947'	,'Grenada Pro'	,'6784'	 ,'Gaming'    ,'4'  ,'8' ,'6' ,'0' ,'275' ,'L' ,'309.99')
,('nVidia'	,'GTX 960'	,'1127'	,'Maxwell'		,'5978'	 ,'Gaming'    ,'2'  ,'6' ,'0' ,'0' ,'120' ,'L' ,'199.99')
,('AMD'		,'R9 380'	,'918'	,'Antigua Pro'	,'5542'	 ,'Gaming'    ,'2'  ,'8' ,'6' ,'0' ,'190' ,'L' ,'199.99')
,('nVidia'	,'GTX 950'	,'1024'	,'Maxwell'		,'5308'	 ,'Gaming'    ,'2'  ,'8' ,'0' ,'0' ,'90'  ,'S' ,'159.99')
,('AMD'		,'R7 370'	,'900'	,'Curacao'		,'4213'	 ,'Gaming'    ,'2'  ,'6' ,'0' ,'0' ,'150' ,'L' ,'129.99')
,('AMD'		,'HD 5450'	,'650'	,'Cedar'		,'231'	 ,'Basic'  	  ,'2'  ,'0' ,'0' ,'0' ,'250' ,'L' ,'34.99' )
,('AMD'		,'R7 360'	,'1050'	,'Bonaire Pro'	,'3198'	 ,'Gaming'    ,'2'  ,'6' ,'0' ,'0' ,'150' ,'S' ,'99.99' )
,('nVidia'	,'GTX 750Ti','1020'	,'Maxwell'		,'3687'	 ,'Gaming'    ,'2'  ,'6' ,'0' ,'0' ,'60'  ,'S' ,'125.99')

--,('','','','','','','','','','','','','','')
--Model,Model,ClockSpeed,ProductLineName,BenchmarkScore,BestUse,GpuRamSize,PciPinConnector1,PciPinConnector2,PciPinConnector3,PowerRequirement,GpuLength,Price
GO


/*************************************/
/*        MOTHERBOARD  INSERT        */
/*************************************/
INSERT INTO Motherboards
VALUES
 ('ASRock'		,'AM1B-M'					,'AM1'    ,'none'	,'16' ,'3' ,'mATX' ,'2'  ,'0' ,'3'  ,'3' ,'0' ,'0' ,'1' ,'1' ,'0' ,'33.99' )
,('ASRock'		,'AM1H-ITX'					,'AM1'    ,'none'	,'16' ,'3' ,'mITX' ,'4'  ,'0' ,'3'  ,'3' ,'0' ,'0' ,'1' ,'0' ,'0' ,'48.99' )
,('Gigabyte'	,'GA-78LMT-USB3'			,'AM3+'   ,'760G'	,'32' ,'3' ,'mATX' ,'6'  ,'0' ,'5'  ,'2' ,'1' ,'0' ,'0' ,'1' ,'1' ,'58.99' )
,('MSI'			,'970A-G43'					,'AM3+'   ,'970'	,'32' ,'3' ,'ATX'  ,'6'  ,'0' ,'5'  ,'3' ,'1' ,'0' ,'1' ,'1' ,'1' ,'69.99' )
,('Gigabyte'	,'GA-990FXA-UD5'			,'AM3+'   ,'990FX'	,'32' ,'3' ,'ATX'  ,'8'  ,'0' ,'10' ,'4' ,'1' ,'1' ,'2' ,'1' ,'1' ,'144.99')
,('Asus'		,'ROG Crosshair V Formula'	,'AM3+'   ,'990FX'	,'32' ,'3' ,'ATX'  ,'8'  ,'0' ,'9'  ,'6' ,'2' ,'1' ,'1' ,'1' ,'0' ,'239.99')
,('MSI'			,'A88XI'					,'FM2+'   ,'A88X'	,'16' ,'3' ,'mITX' ,'4'  ,'0' ,'5'  ,'2' ,'1' ,'0' ,'0' ,'0' ,'0' ,'126.99')
,('MSI'			,'A68HI'					,'FM2+'   ,'A68'	,'16' ,'3' ,'mITX' ,'4'  ,'0' ,'5'  ,'2' ,'1' ,'0' ,'0' ,'0' ,'0' ,'79.99' )
,('ASRock'		,'FM2A88X+'					,'FM2+'   ,'A88X'	,'32' ,'3' ,'ATX'  ,'8'  ,'0' ,'6'  ,'3' ,'1' ,'0' ,'1' ,'3' ,'0' ,'69.99' )
,('Asus'		,'A88XM-A'					,'FM2+'   ,'A88X'	,'32' ,'3' ,'mATX' ,'6'  ,'0' ,'5'  ,'2' ,'1' ,'0' ,'0' ,'1' ,'1' ,'73.99' )
,('MSI'			,'A78M-E35'					,'FM2+'   ,'A78'	,'16' ,'3' ,'mATX' ,'6'  ,'0' ,'5'  ,'3' ,'1' ,'0' ,'0' ,'1' ,'1' ,'59.99' )
,('MSI'			,'A68HM-GRENADE'			,'FM2+'   ,'A68'	,'16' ,'3' ,'mATX' ,'4'  ,'0' ,'5'  ,'2' ,'1' ,'0' ,'0' ,'1' ,'1' ,'54.99' )
,('ECS'			,'A58F2P-M2'				,'FM2+'   ,'A58'	,'16' ,'3' ,'mATX' ,'4'  ,'0' ,'4'  ,'2' ,'1' ,'0' ,'0' ,'1' ,'1' ,'45.99' )
,('ASRock'		,'H81M-ITX'					,'1150'   ,'H81'	,'16' ,'3' ,'mITX' ,'2'  ,'0' ,'4'  ,'2' ,'1' ,'0' ,'0' ,'0' ,'0' ,'54.99' )
,('Gigabyte'	,'GA-H97N-WIFI'				,'1150'   ,'H97'	,'16' ,'2' ,'mITX' ,'4'  ,'0' ,'4'  ,'1' ,'1' ,'0' ,'0' ,'0' ,'0' ,'117.00')
,('MSI'			,'H81M-P33'					,'1150'   ,'H81'	,'16' ,'3' ,'mATX' ,'4'  ,'0' ,'3'  ,'2' ,'1' ,'0' ,'0' ,'1' ,'0' ,'45.99' )
,('ASRock'		,'Z97M Pro4'				,'1150'   ,'Z97'	,'32' ,'3' ,'mATX' ,'6'  ,'0' ,'4'  ,'4' ,'1' ,'0' ,'1' ,'0' ,'2' ,'99.99' )
,('Gigabyte'	,'GA-Z97MX-Gaming 5'		,'1150'   ,'Z97'	,'32' ,'3' ,'mATX' ,'8'  ,'1' ,'4'  ,'4' ,'1' ,'1' ,'1' ,'1' ,'0' ,'134.99')
,('MSI'			,'PCMate'					,'1150'   ,'Z97'	,'32' ,'3' ,'ATX'  ,'6'  ,'0' ,'6'  ,'4' ,'1' ,'1' ,'0' ,'2' ,'2' ,'84.99' )
,('ASRock'		,'Fatal1ty'					,'1150'   ,'Z97'	,'32' ,'3' ,'ATX'  ,'6'  ,'1' ,'9'  ,'5' ,'1' ,'0' ,'1' ,'1' ,'2' ,'109.99')
,('Gigabyte'	,'GA-Z97X-UD3H'				,'1150'   ,'Z97'	,'32' ,'3' ,'ATX'  ,'8'  ,'1' ,'8'  ,'5' ,'1' ,'1' ,'1' ,'3' ,'1' ,'124.99')
,('Gigabyte'	,'GA-Z97X-Gaming 7'			,'1150'   ,'Z97'	,'32' ,'3' ,'ATX'  ,'8'  ,'1' ,'8'  ,'5' ,'1' ,'1' ,'1' ,'3' ,'1' ,'174.99')
,('ASRock'		,'H110M-ITX'				,'1151'   ,'H110'	,'16' ,'4' ,'mITX' ,'4'  ,'0' ,'5'  ,'1' ,'1' ,'0' ,'0' ,'0' ,'0' ,'69.99' )
,('ASRock'		,'Z170M-ITX'				,'1151'   ,'Z170'	,'16' ,'4' ,'mITX' ,'4'  ,'0' ,'6'  ,'2' ,'1' ,'0' ,'0' ,'0' ,'0' ,'128.99')
,('Asus'		,'MAXIMUS VIII IMPACT'		,'1151'   ,'Z170'	,'16' ,'4' ,'mITX' ,'4'  ,'0' ,'12' ,'2' ,'1' ,'0' ,'0' ,'0' ,'0' ,'248.99')
,('ASRock'		,'Gaming-ITX'				,'1151'   ,'Z170'	,'16' ,'4' ,'mITX' ,'6'  ,'0' ,'8'  ,'3' ,'1' ,'0' ,'0' ,'0' ,'0' ,'171.99')
,('ASRock'		,'H110M-DGS'				,'1151'   ,'H110'	,'16' ,'4' ,'mATX' ,'4'  ,'0' ,'3'  ,'2' ,'1' ,'0' ,'0' ,'0' ,'0' ,'54.99' )
,('MSI'			,'B150M BAZOOKA'			,'1151'   ,'B150'	,'16' ,'4' ,'mATX' ,'6'  ,'0' ,'6'  ,'3' ,'1' ,'0' ,'0' ,'2' ,'0' ,'84.99' )
,('ASRock'		,'Extreme4'					,'1151'   ,'Z170'	,'32' ,'4' ,'mATX' ,'6'  ,'1' ,'7'  ,'3' ,'1' ,'1' ,'1' ,'1' ,'0' ,'114.99')
,('Gigabyte'	,'GA-Z170MX-Gaming 5'		,'1151'   ,'Z170'	,'32' ,'4' ,'mATX' ,'6'  ,'1' ,'7'  ,'4' ,'1' ,'2' ,'0' ,'1' ,'0' ,'149.99')
,('Asus'		,'MAXIMUS VIII GENE'		,'1151'   ,'Z170'	,'32' ,'4' ,'mATX' ,'6'  ,'1' ,'10' ,'5' ,'1' ,'1' ,'1' ,'0' ,'0' ,'228.99')
,('MSI'			,'PC Mate'					,'1151'   ,'B150'	,'32' ,'4' ,'ATX'  ,'6'  ,'1' ,'6'  ,'5' ,'1' ,'1' ,'0' ,'3' ,'2' ,'89.99' )
,('MSI'			,'Z170-A PRO'				,'1151'   ,'Z170'	,'32' ,'4' ,'ATX'  ,'6'  ,'1' ,'6'  ,'5' ,'1' ,'1' ,'0' ,'4' ,'0' ,'99.99' )
,('Gigabyte'	,'GA-Z170X-UD3'				,'1151'   ,'Z170'	,'32' ,'4' ,'ATX'  ,'6'  ,'2' ,'11' ,'4' ,'1' ,'2' ,'0' ,'3' ,'0' ,'144.99')
,('EVGA'		,'140-SS-E177-KR'			,'1151'   ,'Z170'	,'32' ,'4' ,'ATX'  ,'6'  ,'0' ,'8'  ,'7' ,'4' ,'0' ,'1' ,'0' ,'0' ,'189.99')
,('ASRock'		,'OC Formula'				,'1151'   ,'Z170'	,'32' ,'4' ,'ATX'  ,'8'  ,'3' ,'17' ,'6' ,'1' ,'1' ,'2' ,'3' ,'0' ,'237.99')
,('Asus'		,'Z170-DELUXE'				,'1151'   ,'Z170'	,'32' ,'4' ,'ATX'  ,'8'  ,'1' ,'18' ,'4' ,'1' ,'2' ,'0' ,'4' ,'0' ,'319.99')
,('Gigabyte'	,'GA-X99-SLI'				,'2011v3' ,'X99'	,'64' ,'4' ,'ATX'  ,'10' ,'1' ,'9'  ,'4' ,'2' ,'2' ,'0' ,'3' ,'0' ,'199.99')
,('ASRock'		,'Fatal1ty'					,'2011v3' ,'X99'	,'64' ,'4' ,'ATX'  ,'10' ,'1' ,'8'  ,'6' ,'3' ,'0' ,'0' ,'2' ,'0' ,'239.99')
,('Asus'		,'X99-M WS'					,'2011v3' ,'X99'	,'32' ,'4' ,'mATX' ,'8'  ,'1' ,'8'  ,'4' ,'2' ,'1' ,'0' ,'1' ,'0' ,'275.99')
,('Gigabyte'	,'GA-X99-Gaming 5P'			,'2011v3' ,'X99'	,'64' ,'4' ,'ATX'  ,'10' ,'2' ,'9'  ,'4' ,'2' ,'1' ,'0' ,'3' ,'0' ,'309.99')
,('Asus'		,'X99-DELUXE'				,'2011v3' ,'X99'	,'64' ,'4' ,'ATX'  ,'10' ,'1' ,'8'  ,'4' ,'2' ,'3' ,'1' ,'0' ,'0' ,'399.99')
,('ASRock'		,'X99 WS-E'					,'2011v3' ,'X99'	,'64' ,'4' ,'ATX'  ,'12' ,'1' ,'12' ,'5' ,'4' ,'3' ,'0' ,'0' ,'0' ,'649.99')

--,('','','','','','','','','','','','','','','','','')
--Brand,Model,Socket,Chipset,MaxRam,RamType,FormFactor,SataPorts,M2Slots,PowerPhases,FanHeaders,Pcie16,Pcie8,Pcie4,Pcie1,Pci,Price
GO


/*************************************/
/*            RAM  INSERT            */
/*************************************/
INSERT INTO RAM
VALUES
 ('GSkill'	,'F3-12800CL9D-8GBXL'	,'8'  ,'3' ,'1600' ,'09-09-09-24-2N' ,'Basic'  	  ,'42.99' )
,('GSkill'	,'F3-2666C11D-8GTXD'	,'8'  ,'3' ,'2666' ,'11-13-13-35-2N' ,'Gaming' 	  ,'77.99' )
,('GSkill'	,'F3-2400C10D-8GTX'		,'8'  ,'3' ,'2400' ,'10-12-12-31-2N' ,'Office' 	  ,'51.99' )
,('GSkill'	,'F3-2666C11D-16GTXD'	,'16' ,'3' ,'2666' ,'11-13-13-35-2N' ,'Gaming' 	  ,'199.99')
,('Patriot'	,'PV316G240C0KBL'		,'16' ,'3' ,'2400' ,'10-12-12-30-2N' ,'Gaming' 	  ,'91.99' )
,('GSkill'	,'F3-1600C9D-16GAR'		,'16' ,'3' ,'1600' ,'09-09-09-24-2N' ,'Basic'  	  ,'59.99' )
,('Corsair'	,'CMK16GX4M2A2133C13R'	,'16' ,'4' ,'2133' ,'15-15-15-36-2N' ,'Gaming' 	  ,'93.99' )
,('Kingston','HX426C13SBK2'			,'16' ,'4' ,'2666' ,'13-14-14-33-2N' ,'Gaming' 	  ,'144.99')
,('GSkill'	,'F4-3600C17D-16GVK'	,'16' ,'4' ,'3600' ,'17-18-18-38-2N' ,'Gaming' 	  ,'169.99')
,('Corsair'	,'CMK8GX4M2A2133C13R'	,'8'  ,'4' ,'2133' ,'13-15-15-28-2N' ,'Office' 	  ,'53.99' )
,('Kingston','HX426C13SBK2'			,'8'  ,'4' ,'2666' ,'13-13-13-33-2N' ,'Gaming' 	  ,'88.99' )
,('GSkill'	,'F4-3600C17D-8GTZ'		,'8'  ,'4' ,'3600' ,'17-18-18-38-2N' ,'Gaming' 	  ,'99.99' )
,('GSkill'	,'F4-2133C15Q-32GVR'	,'32' ,'4' ,'2133' ,'15-15-15-35-2N' ,'Gaming'	  ,'159.99')
,('Corsair'	,'CMK32GX4M4A2666C15'	,'32' ,'4' ,'2666' ,'15-17-17-35-2N' ,'Rendering' ,'219.99')
,('GSkill'	,'F4-3400C16Q-32GTZ'	,'32' ,'4' ,'3400' ,'16-18-18-38-2N' ,'Rendering' ,'319.99')
,('Mushkin'	,'994110E'				,'32' ,'3' ,'1600' ,'09-09-09-24-2N' ,'Rendering' ,'135.99')
,('GSkill'	,'F3-2400C11Q-32GZM'	,'32' ,'3' ,'2400' ,'11-13-13-31-2N' ,'Rendering' ,'149.99')
,('GSkill'	,'F3-2666C12Q-32GTXD'	,'32' ,'3' ,'2666' ,'12-13-13-35-2N' ,'Rendering' ,'259.99')

--,('','','','','','','','','')
--Brand,Model,RamSize,RamGeneration,RamSpeed,RamTimings,BestUse,Price
GO


/*************************************/
/*            PSU  INSERT            */
/*************************************/
INSERT INTO PSU
VALUES
 ('SeaSonic' ,'SSP-350SE'		,'300'  ,'B' ,'34.99' )
,('Corsair'	 ,'CX430'			,'430'  ,'B' ,'39.99' )
,('Corsair'	 ,'CX500'			,'500'  ,'B' ,'52.39' )
,('Corsair'	 ,'CX600'			,'600'  ,'B' ,'59.99' )
,('EVGA'	 ,'110-B2-0750-VR'	,'750'  ,'B' ,'68.99' )
,('EVGA'	 ,'110-B2-0850-V1'	,'850'  ,'B' ,'99.99' )
,('EVGA'	 ,'120-G1-1000-VR'	,'1000' ,'G' ,'139.99')
,('SeaSonic' ,'SS-1200XP3'		,'1200' ,'P' ,'219.99')
,('Corsair'	 ,'AX1500i'			,'1500' ,'P' ,'399.99')
,('LEPA'	 ,'MX-F1N350-SB'	,'350'  ,'X' ,'29.99' )

--,('','','','','')
--Brand,Model,Wattage,Efficiency,Price
GO


/*************************************/
/*          STORAGE  INSERT          */
/*************************************/
INSERT INTO Storage
VALUES
 ('Seagate'	,'ST3250312AS'			,'250'  ,'HDD' ,'1053' ,'90'  ,'90'   ,'115'   ,'130'   ,'Basic'		,'19.99' )
,('WD'		,'WD3200AAJS'			,'320'  ,'HDD' ,'1046' ,'90'  ,'90'   ,'115'   ,'130'   ,'Office'		,'25.00' )
,('Hitachi'	,'HUA721075KLA330'		,'750'  ,'HDD' ,'922'  ,'90'  ,'90'   ,'115'   ,'130'   ,'Software'		,'34.99' )
,('Hitachi'	,'HDE721010SLA330'		,'1024' ,'HDD' ,'922'  ,'90'  ,'90'   ,'115'   ,'130'   ,'Software'		,'44.50' )
,('Seagate'	,'ST1000DM003'			,'1024' ,'HDD' ,'1046' ,'90'  ,'90'   ,'115'   ,'130'   ,'Gaming'		,'47.99' )
,('WD'		,'WD2003FZEX'			,'2048' ,'HDD' ,'1080' ,'90'  ,'90'   ,'115'   ,'130'   ,'Gaming'		,'119.99')
,('WD'		,'WD4003FZEX'			,'4096' ,'HDD' ,'1148' ,'90'  ,'90'   ,'115'   ,'130'   ,'Gaming'		,'198.99')
,('WD'		,'WD6001FZWX'			,'6144' ,'HDD' ,'1100' ,'90'  ,'90'   ,'115'   ,'130'   ,'Gaming'		,'289.99')
,('A-Data'	,'ASP550SS3-120GM-C'	,'120'  ,'SSD' ,'3282' ,'560' ,'530'  ,'60000' ,'70000' ,'Office'		,'42.99' )
,('A-Data'	,'ASP550SS3-240GM-C'	,'240'  ,'SSD' ,'3282' ,'560' ,'480'  ,'75000' ,'75000' ,'Gaming'		,'67.99' )
,('OCZ'		,'TRN100-25SAT3-240G'	,'240'  ,'SSD' ,'3178' ,'550' ,'520'  ,'91000' ,'43000' ,'Gaming'		,'69.49' )
,('Sandisk'	,'SDSSDHII-480G-G25'	,'480'  ,'SSD' ,'3769' ,'550' ,'500'  ,'98000' ,'83000' ,'Rendering'	,'140.13')
,('Mushkin'	,'MKNSSDCR480GB-7-A'	,'480'  ,'SSD' ,'3889' ,'540' ,'460'  ,'78000' ,'37000' ,'Rendering'	,'139.99')
,('Samsung'	,'MZ-75E1T0B/'			,'1024' ,'SSD' ,'4397' ,'540' ,'520'  ,'98000' ,'90000' ,'Rendering'	,'343.81')
,('Samsung'	,'MZ-75E2T0B'			,'2048' ,'SSD' ,'4388' ,'540' ,'520'  ,'98000' ,'90000' ,'Rendering'	,'699.99')

--,('','','','','','','','','','','')
--Brand,Model,StorageSize,StorageType,BenchmarkScore,StorageSequentialRead,StorageSequentialWrite,StorageRandomRead,StorageRandomWrite,BestUse,Price
GO


/*************************************/
/*          OPTICAL  INSERT          */
/*************************************/
INSERT INTO Optical
VALUES
 ('LG'		,'WH14NS40'	  ,'BluRay Burner'	,'52.99')
,('Asus'	,'BW-12B1ST'  ,'BluRay Burner'	,'59.99')
,('LG'		,'UH12NS30'	  ,'BluRay Reader'	,'34.99')
,('Lite-On' ,'IHAS124-14' ,'DVD Burner'		,'19.99')
,('Asus'	,'DRW-24B1ST' ,'DVD Burner'		,'19.99')
,('LG'		,'GH24NSC0B'  ,'DVD Burner'		,'19.99')

--,('','','','')
--Brand,Model,OpticalType,Price
GO


/*************************************/
/*           ROLES  INSERT           */
/*************************************/
INSERT INTO [Roles]
VALUES
 ('Administrator','Software administrator with full access to CRUD program. May make any changes to the program.')
,('Registered','A registered and logged in user. Registered will have standard access and no administrator rights.')
,('Guest','An unregistered or logged out user. Will have basic access to the program.')

--,('','')
--RoleName,RoleDescription
GO


/*************************************/
/*           USERS  INSERT           */
/*************************************/
INSERT INTO Users
VALUES
 ('Luke','Frahm','2707 Iris Ave NW','Cedar Rapids','IA','52405','3196518538','lukefrahm@gmail.com','lukefrahm','password','Administrator','1')
,('Randy','Frahm','1610 Hinkley Ave NW','Cedar Rapids','IA','52405','3195733383','frahms_4@imon.com','randyfrahm','password','Registered','1')

--,('','','','','','','','','','','','')
--FirstName,LastName,Address,City,StateCode,Zip,LocalPhone,EmailAddress,Username,Password,RoleName,Active
GO

/*************************************/
/*  END OF POPULATION INSERT SCRIPT  */
/*************************************/