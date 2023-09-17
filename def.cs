namespace units
{
    public class MassUnits
    {
        public const double Kg = 1;
        public const double Tonne = 1000.0;
        public const double Electronvolt = 1.602176634e-19;
        public const double Dalton = 1.66053906660e-27;
        public const double Gram = 0.001;
        public const double Slug = 14.59390294;
        public const double PlanckMass = 2.176470e-8;
        public const double SolarMass = 1.9885e30;
        public const double Grain = 0.00006479891;
        public const double Drachm = 0.0017718451953125;
        public const double Ounce = 0.028349523125;
        public const double Pound = 0.45359237;
        public const double Stone = 6.35029318;
        public const double Quarter = 12.70058636;
        public const double Hundredweight = 50.80234544;
        public const double Ton = 1016.0469088;
    }

    public class ThermodynamicTemperatureUnits
    {
        
        public const double Kelvin = 1.0;
        public const double Celsius = 1.0;
        public const double Fahrenheit = 5.0 / 9.0;
        public const double Rankine = 5.0 / 9.0;
        public const double Delisle = -2.0 / 3.0;
        public const double Newton = 100.0 / 33.0;
        public const double Réaumur = 5.0 / 4.0;
        public const double Rømer = 40.0 / 21.0;
        public const double AbsoluteZeroInKelvin = 0.0;
        public const double AbsoluteZeroInCelsius = -273.15;
        public const double AbsoluteZeroInFahrenheit = -459.67;
        public const double AbsoluteZeroInRankine = 0.0;
        public const double AbsoluteZeroInDelisle = 559.725;
        public const double AbsoluteZeroInNewton = 0.0;
        public const double AbsoluteZeroInRéaumur = -218.52;
        public const double AbsoluteZeroInRømer = 7.5;
    }

    public class LengthUnits
    {
        public const double Meters = 1.0;
        public const double Inches = 0.0254;
        public const double Feet = 0.3048;
        public const double Yards = 0.9144;
        public const double Miles = 1609.344;
        public const double ThouOrMil = 0.0000254;
        public const double TerrestrialMile = 1609.344;
        public const double LandLeague = 4800.0;
        public const double Fermi = 1e-15;
        public const double Angstrom = 1e-10;
        public const double Micron = 1e-6;
        public const double NorwegianOrSwedishMil = 10000.0;
        public const double XUnit = 0.1e-12;
        public const double Fathom = 1.8288;
        public const double NauticalMile = 1852.0;
        public const double Chain = 20.1168;
        public const double Rod = 5.0292;
        public const double EarthRadius = 6371000.0;
        public const double LunarDistance = 384402000.0;
        public const double AstronomicalUnit = 149597870700.0;
        public const double LightYear = 9460730472580.8;
        public const double Parsec = 30856775814671.9;
        public const double HubbleLength = 4.55e9 * LengthUnits.LightYear;
        public const double ClassicalElectronRadius = 2.817940285e-15;
        public const double ComptonWavelengthOfElectron = 2.426310215e-12;
        public const double ReducedComptonWavelengthOfElectron = 3.8615926764e-13;
        public const double BohrRadius = 5.291772083e-11;
        public const double ReducedWavelengthOfHydrogenRadiation = 9.112670505509e-8;
        public const double PlanckLength = 1.616199e-35;
        public const double StoneyUnitOfLength = 1.381e-35;
        public const double QCDUnitOfLength = 2.103e-16;
        public const double NaturalUnitsBasedOnElectronvolt = 1.97e-7;
    }

    public class AngleUnits
    {
        public const double Steradian = 1.0;
        public const double Radian = 1.0;
        public const double Degree = UniversalConstants.Pi / 180.0;
        public const double Arcminute = UniversalConstants.Pi / 10800.0;
        public const double Grad = UniversalConstants.Pi / 200.0;
        public const double BinaryDegree = UniversalConstants.Pi / 256.0;
        public const double PiRadian = UniversalConstants.Pi / 2.0;
        public const double Sextant = UniversalConstants.Pi / 3.0;
        public const double DiameterPart = UniversalConstants.Pi;
    }
    public class ForceWeightUnits
    {
        public const double Newton = 1.0;
        public const double Dyne = 1.0;
        public const double Kilopond = 9.80665;
        public const double PoundForce = 4.448222;
        public const double Poundal = 0.138255;
    }

    public class PressureStressUnits
    {
        public const double Pascal = 1.0;
        public const double PoundForcePerSquareFoot = 47.880259;
        public const double PoundForcePerSquareInch = 6894.76;
        public const double OunceForcePerSquareInch = 430.92233;
        public const double InchWaterColumn = 248.84;
        public const double MillimeterH2O = 9.80665;
        public const double CentimeterH2O = 98.0665;
        public const double MeterH2O = 9806.65;
        public const double MillimeterHg = 133.322;
        public const double CentimeterHg = 1333.22;
        public const double MeterHg = 133322.0;
        public const double InchWaterColumnToInH2O = 248.84;
        public const double FootWaterColumn = 2986.98;
        public const double InchMercury = 3386.39;
        public const double MillimeterH2OAt4C = 9.80638;
        public const double MillimeterH2OAt60F = 8.80159;
        public const double MillimeterH2OAt68F = 8.79968;
        public const double CentimeterH2OAt4C = 98.0638;
        public const double CentimeterH2OAt60F = 88.0158;
        public const double CentimeterH2OAt68F = 87.9968;
        public const double InchH2OAt60F = 248.839;
        public const double InchH2OAt68F = 248.831;
        public const double InchH2OAt4C = 248.84;
        public const double FootH2OAt60F = 2986.98;
        public const double FootH2OAt68F = 2986.58;
        public const double FootH2OAt4C = 2986.98;
        public const double Atmosphere = 101325.0;
        public const double Bar = 100000.0;
        public const double Torr = 133.322;
    }

    public class EnergyWorkHeatUnits
    {
        public const double Calorie = 4.184;
        public const double Joule = 1.0;
        public const double KilowattHour = 3600000.0;
        public const double KilowattMinute = 60000.0;
        public const double Therm = 105505585.257;
        public const double Electronvolt = 1.602176634e-19;
        public const double TNTTonne = 4184000000.0;
    }

    public class MomentOfForceUnits
    {
        public const double NewtonMeter = 1.0;
        public const double PoundForceFeet = 0.11298483;
        public const double OunceForceInches = 0.00706155198;
    }

    public class AngularVelocityFrequencyUnits
    {
        public const double Hertz = 1.0;
        public const double RadianPerSecond = 1.0;
        public const double DegreePerSecond = 0.0174533;
        public const double GradPerSecond = 0.01570796;
        public const double RadianPerHour = 0.00027777778;
        public const double DegreePerHour = 0.00000484814;
        public const double GradPerHour = 0.00000436332;
        public const double BinaryDegreePerSecond = 0.00174533;
    }

    public class AngularAccelerationUnits
    {
        public const double RadianPerSecondSquared = 1.0;
        public const double DegreePerSecondSquared = 0.0174533;
        public const double GradPerSecondSquared = 0.01570796;
        public const double RadianPerHourSquared = 0.00027777778;
        public const double DegreePerHourSquared = 0.00000484814;
        public const double GradPerHourSquared = 0.00000436332;
    }

    public class ThermalConductivityUnits
    {
        public const double WattMeterKelvin = 1.0;
        public const double BritishThermalUnit = 0.000947817;
        public const double RValue = 1.0;
        public const double UValue = 1.0;
        public const double Tog = 0.1;
        public const double Clo = 0.155;
    }

    public class EnergyDensityUnits
    {
        public const double JoulePerCubicMeter = 1.0;
        public const double JoulePerLiter = 1000.0;
        public const double WattHourPerLiter = 3600000.0;
    }

    public class MolarEnergyUnits
    {
        public const double KilocaloriesPerMole = 1.0;
        public const double ElectronVoltsPerParticle = 1.0;
        public const double WavenumbersPerCentimeter = 1.0;
        public const double JoulePerMole = 1.0;
    }

    public class CatalyticActivityConcentrationUnits
    {
        public const double TOF = 1.0;
        public const double TON = 1.0;
        public const double Katal = 1.0;
    }

    public class ElectricChargeUnits
    {
        public const double Coulomb = 1.0;
        public const double Electron = 1.602176634e-19;
    }

    public class CapacitanceUnits
    {
        public const double Farad = 1.0;
        public const double Abfarad = 1e9;
        public const double Statfarad = 1.112650e-12;
    }

    public class ResistanceImpedanceReactanceUnits
    {
        public const double Ohm = 1.0;
        public const double AbsoluteFootPerSecond = 1e7;
        public const double ThomsonUnit = 1.0;
        public const double JacobiCopperUnit = 1.0;
        public const double WebersAbsoluteUnit = 1e7;
        public const double SiemensMercuryUnit = 1860.0;
        public const double BritishAssociationOhm = 1.0;
        public const double DigneyBreguetSwiss = 1.0;
        public const double Matthiessen = 1.0;
        public const double Varley = 1.0;
        public const double GermanMile = 7.5861423e3;
        public const double Abohm = 1e9;
        public const double Statohm = 8.987554e11;
    }

    public class ElectricalConductanceUnits
    {
        public const double Mho = 1.0;
        public const double Siemens = 1.0;
    }

    public class MagneticFluxUnits
    {
        public const double Weber = 1.0;
        public const double Maxwell = 1e-8;
    }

    public class AbsorbedDoseUnits
    {
        public const double Gray = 1.0;
        public const double Rad = 0.01;
    }

    public class EquivalentDoseUnits
    {
        public const double Sievert = 1.0;
        public const double RoentgenEquivalentToSievert = 0.01;
    }

    public class CatalyticActivityUnits
    {
        public const double Tof = 1.0;
        public const double Ton = 1000.0;
    }

    public class AreaUnits
    {
        public const double SquareMeter = 1.0;
        public const double SquareFoot = 0.092903;
        public const double SquareYard = 0.836127;
        public const double SquareMile = 2589988.110336;
        public const double SquareInch = 0.000645;
        public const double SquareHectare = 10000.0;
        public const double SquareAcre = 4046.86;
        public const double SquareBarn = 1e-28;
    }

    public class VolumeUnits
    {
        public const double CubicMeter = 1.0;
        public const double Liter = 0.001;
        public const double CubicInch = 0.000016387064;
        public const double CubicFoot = 0.0283168466;
        public const double CubicYard = 0.764554858;
        public const double AcreFoot = 1233.5;
        public const double CubicMile = 4168181825.440579584;
        public const double Minim = 0.0000616115;
        public const double Drachm = 0.00355118;
        public const double FluidOunce = 0.0295735;
        public const double Pint = 0.473176;
        public const double Teaspoon = 0.00000591939;
        public const double Tablespoon = 0.0000177588;
        public const double Gill = 0.118294;
        public const double Quart = 0.946353;
        public const double Gallon = 3.78541;
        public const double Barrel = 158.987;
        public const double Cord = 3.62456;
        public const double Peck = 0.00880977;
        public const double Bushel = 0.0352391;
        public const double Hogshead = 238.481;
    }

    public class SpeedVelocityUnits
    {
        public const double MeterPerSecond = 1.0;
        public const double KilometerPerHour = 0.277778;
        public const double MilePerHour = 0.44704;
        public const double Knots = 0.514444;
        public const double FeetPerSecond = 0.3048;
        public const double MachNumber = 343.2;
        public const double NaturalUnitSpeed = 299792458.0;
    }

    public class AccelerationUnits
    {
        public const double MeterPerSecondSquared = 1.0;
        public const double Gal = 1.0;
        public const double FeetPerSecondSquared = 0.3048;
        public const double G0 = 9.80665;
    }

    public class DensityUnits
    {
        public const double KilogramPerLiter = 1000.0;
        public const double GramPerMilliliter = 1.0;
        public const double TonnePerCubicMeter = 1.0;
        public const double KilogramPerCubicDecimeter = 1000.0;
        public const double GramPerCubicCentimeter = 1000.0;
        public const double MegagramPerCubicMeter = 1.0;
        public const double AvoirdupoisOuncePerCubicInch = 16.387064;
        public const double AvoirdupoisOuncePerFluidOunce = 1.04317556;
        public const double AvoirdupoisPoundPerCubicInch = 27679.9;
        public const double PoundPerCubicFoot = 16.0185;
        public const double PoundPerCubicYard = 0.593276;
        public const double PoundPerUSLiquidGallon = 8.34540445;
        public const double PoundPerUSBushel = 77.6888513;
        public const double SlugPerCubicFoot = 515.379;
    }

    public class LuminanceUnits
    {
        public const double CandelaPerSquareMeter = 1.0;
        public const double Stilb = 1e4;
        public const double Apostilb = 1e-4;
        public const double Bril = 1e12;
        public const double Skot = 1e-6;
        public const double Lambert = 1e4;
        public const double FootLambert = 1.07639;
        public const double Femtolambert = 1e-15;
    }

    public class DynamicViscosityUnits
    {
        public const double SquareMeterPerSecond = 1.0;
        public const double Poise = 0.1;
        public const double Centipoise = 1.0;
        public const double Stokes = 1e-4;
        public const double PoundForceSecond = 0.0421401;
        public const double SquareFeetPerSecond = 0.092903;
        public const double Reyn = 6894.76;
        public const double Rhe = 10.0;
    }
    public class UniversalConstants
    {
        public const double Pi = 3.14159265358979323846;
        public const double EulerNumber = 2.71828182845904523536;
        public const double Tau = 2 * Pi;
        public const double Sqrt2 = 1.41421356237309504880;
        public const double GoldenRatio = 1.61803398875;
        public const double EulerMascheroniConstant = 0.577215664901532860606;
        public const double CatalanConstant = 0.915965594177;
        public const double GlaisherConstant = 1.2824271291;
        public const double KhinchinConstant = 2.68545200107;
        public const double CopelandErdosConstant = 0.235711131719232931374143;
        public const double LandauRamanujanConstant = 0.764223653589;
        public const double MeisselMertensConstant = 0.261497212847;
        public const double PlasticityConstant = 1.3247179572;
        public const double ReciprocalFibonacciConstant = 3.35988566624;
        public const double SmarandacheWellinConstant = 0.64676025812;
        public const double TwinPrimeConstant = 0.66016181585;
        public const double FeigenbaumConstantAlpha = 2.502907875095;
        public const double FeigenbaumConstantDelta = 4.6692016091029906718532038204662016172581855774757686327456513430041343;
        public const double GlaisherKinkelinConstant = 1.28242712910062263687;
        public const double SquareRootOf2 = 1.41421356237309504880;
        public const double SquareRootOf3 = 1.73205080756887729352;
        public const double SquareRootOf5 = 2.23606797749978969640;
        public const double SquareRootOf7 = 2.64575131106459059050;
        public const double GoldenRatioReciprocal = 0.61803398875;
        public const double PlasticNumber = 1.32471795724474602596;
        public const double OmegaConstant = 0.56714329040978387299;
        public const double RiemannZeta2 = 1.64493406684822643647;
        public const double RiemannZeta3 = 1.20205690315959428539;
        public const double RiemannZeta4 = 1.08232323371113819152;
        public const double RiemannZeta5 = 1.03692775514336992633;
        public const double RiemannZeta6 = 1.01734306198444913971;
        public const double EulerGammaSquared = 0.33361135255786946674;
        public const double EulerGammaCubed = 0.18093659314402832429;
        public const double PiSquared = 9.86960440108935861883;
        public const double PiCubed = 31.00627668029982017547;
        public const double PiToTheFourth = 97.40909103400243721653;
        public const double PiToTheFifth = 306.01968478528158107136;
        public const double PiToTheSixth = 961.38919357530419451032;
        public const double PiToTheSeventh = 3024.93895808240936582822;
        public const double PiToTheEighth = 9488.53101607013768388124;
        public const double PiToTheNinth = 29728.89421403152616354440;
        public const double SpeedOfLight = 299792458.0;
        public const double GravitationalConstant = 6.67430e-11;
        public const double PlanckConstant = 6.62607015e-34;
        public const double BoltzmannConstant = 1.380649e-23;
        public const double VacuumPermittivity = 8.854187817e-12;
        public const double VacuumPermeability = 4 * Pi * 1.00000000082e-7;
        public const double AvogadroNumber = 6.02214076e23;
        public const double FineStructureConstant = 7.2973525693e-3;
        public const double RydbergConstant = 10973731.568160;
        public const double ElectronMass = 9.10938356e-31;
        public const double ProtonMass = 1.6726219e-27;
        public const double NeutronMass = 1.67492749804e-27;
        public const double PlanckMass = 2.176470e-8;
        public const double HubbleConstant = 6.957e-11;
        public const double CosmicMicrowaveBackgroundTemperature = 2.72548;
        public const double SolarMass = 1.9885e30;
        public const double AstronomicalUnit = 149597870700.0;
        public const double LightYear = 9460730472580.8;
        public const double Parsec = 30856775814671.9;
        public const double GravitationalAccelerationOnEarth = 9.80665;
        public const double ElectronVolt = 1.602176634e-19;
        public const double VacuumSpeedOfLightInInchesPerSecond = 1.186282e10;
        public const double VacuumSpeedOfLightInFeetPerSecond = 3.08568025e8;
        public const double VacuumSpeedOfLightInMilesPerHour = 6.70617066e8;
        public const double VacuumSpeedOfLightInKnots = 5.399568e5;
        public const double VacuumSpeedOfLightInMach = 881120.327;
        public const double VacuumSpeedOfLightInNaturalUnits = 1;
        public const double NewtonianConstantOfGravitation = 6.67430e-11;
        public const double PlanckLength = 1.616199e-35;
        public const double PlanckTime = 5.39116e-44;
        public const double PlanckCharge = 1.875545956e-18;
        public const double ElectronCharge = 1.602176634e-19;
        public const double BohrRadius = 5.291772083e-11;
        public const double RydbergEnergy = 2.179874171e-18;
        public const double StefanBoltzmannConstant = 5.670374419e-8;
        public const double FaradayConstant = 96485.33212;
        public const double MolarGasConstant = 8.314462618;
        public const double StandardAtmosphere = 101325.0;
        public const double FineStructureConstantInverse = 137.035999084;
        public const double SpeedOfSoundInAir = 343.2;
        public const double Neper = 2.71828182845904523536;
        public const double GlaisherKinkelinConstantReciprocal = 0.779877869038985330577900674932859328546735298141192317159786923964641416101882967600912478472828849443;
        public const double AvogadroConstantReciprocal = 1.66053906660e-27;
        public const double BohrMagneton = 927.400e-26;
        public const double NuclearMagnetron = 5.050783699e-27;
        public const double PlanckTemperature = 1.416808e32;
        public const double GravitationalAcceleration = 9.80665;
        public const double BohrMagnetron = 9.27400968e-24;
        public const double BoltzmannConstantReciprocal = 7.2429716e22;
        public const double SpeedOfSoundInWater = 1481.0;
        public const double NeutronMagneticMoment = -9.6623647e-27;
        public const double ProtonMagneticMoment = 1.4106067873e-26;
        public const double NuclearMagnetonReciprocal = 1.4106067873e26;
        public const double AtomicMassUnit = 1.660539040e-27;
        public const double PlanckTimeReciprocal = 1.883531594e43;
        public const double PlanckLengthReciprocal = 6.18771060e34;
        public const double RydbergEnergyReciprocal = 4.587419893e17;
        public const double AvogadroNumberReciprocal = 1.66053906660e-24;
        public const double ElectronChargeSquared = 2.566240054e-35;
        public const double VacuumImpedance = 376.730313668;
        public const double ClassicalElectronRadiusSquared = 8.016813256e-37;
        public const double StefanBoltzmannConstantReciprocal = 1.773301097e-8;
        public const double FineStructureConstantSquared = 0.0072973525693;
        public const double BoltzmannConstantReciprocalSquared = 4.79924330e40;
        public const double PlanckConstantReciprocalSquared = 3.95352576e63;
        public const double VacuumElectricPermittivityReciprocal = 11258999068426240.0;
        public const double VacuumPermeabilityReciprocal = 7.957747154594767e-7;
        public const double ElectronMagneticMomentReciprocal = -6.5812297445e10;
        public const double ProtonMagneticMomentReciprocal = 2.2471009877e10;
        public const double NeutronMagneticMomentReciprocal = -6.53688517e10;
        public const double NuclearMagnetronReciprocal = 1.9826186109e10;
        public const double VacuumSpeedOfLightReciprocal = 3.3356409519815205e-9;
        public const double GravitationalAccelerationReciprocal = 0.10197162129779282;
        public const double BohrMagnetonReciprocal = 1.07715874e-26;
        public const double NuclearMagnetonSquared = 2.799008917994051e-52;
        public const double ElectronGFactor = -2.00231930436153;
        public const double ProtonGFactor = 5.585694702;
        public const double NeutronGFactor = -3.82608545;
        public const double AtomicMassUnitReciprocal = 6.02214076e23;
        public const double PlanckEnergy = 1.956076817e-7;
        public const double PlanckTemperatureReciprocal = 7.055786188e31;
        public const double PlanckTemperatureSquared = 2.474777678e62;
        public const double AvogadroConstantSquared = 3.62756636233e46;
        public const double BoltzmannConstantReciprocalCubed = 1.7484768556e62;
        public const double BoltzmannConstantReciprocalToTheFourth = 4.098034109e82;
        public const double VacuumElectricPermittivity = 8.854187817e-12;
        public const double VacuumPermeabilityReciprocalCubed = 1580493613652158.4;
        public const double VacuumPermeabilityReciprocalToTheFourth = 6.327271583e22;
        public const double ElectronGFactorReciprocal = -0.499023228112;
        public const double ProtonGFactorReciprocal = 0.17908033488;
        public const double NeutronGFactorReciprocal = -0.26123513998;
        public const double PermeabilityOfFreeSpaceSquared = 3.986449063e-25;
        public const double PermeabilityOfFreeSpaceReciprocalCubed = 1125899906842624000.0;
        public const double PlanckLengthReciprocalCubed = 2.062845071e-105;
        public const double PlanckLengthReciprocalToTheFourth = 8.046203936e-141;
        public const double RydbergEnergyReciprocalSquared = 2.108373591e-35;
        public const double ElectronChargeSquaredReciprocal = 3.911507013e35;
        public const double VacuumImpedanceReciprocal = 0.0026544187210050251;
        public const double ClassicalElectronRadiusReciprocal = 3.123732449e6;
        public const double StefanBoltzmannConstantReciprocalSquared = 3.202799029e16;
        public const double FineStructureConstantReciprocalCubed = 2.448242857e8;
        public const double BoltzmannConstantReciprocalToTheFifth = 3.24850856e45;
        public const double VacuumElectricPermittivityReciprocalCubed = 1.077835815e26;
        public const double VacuumElectricPermittivityReciprocalToTheFourth = 1.035335955e51;
        public const double VacuumPermeabilityReciprocalToTheFifth = 1.309567264e60;
        public const double ElectronGFactorReciprocalSquared = 4.00093638704;
        public const double ProtonGFactorReciprocalSquared = 0.0318237186016;
        public const double NeutronGFactorReciprocalSquared = 0.003547043674;
        public const double PermeabilityOfFreeSpaceReciprocalToTheFifth = 1.123945909e20;
    }
    public class PlanckUnits
    {
        public const double PlanckLength = 1.616199e-35;
        public const double PlanckTime = 5.39116e-44;
        public const double PlanckMass = 2.176470e-8;
        public const double PlanckCharge = 1.87554595641e-18;
        public static readonly double PlanckLengthToMeter = 1.0 / PlanckLength;
        public static readonly double PlanckTimeToSecond = 1.0 / PlanckTime;
        public static readonly double PlanckMassToKilogram = 1.0 / PlanckMass;
        public static readonly double PlanckChargeToCoulomb = 1.0 / PlanckCharge;
        public const double PlanckTemperature = 1.416808e32;
        public const double PlanckArea = 2.6120850e70;
        public const double PlanckVolume = 4.22172e105;
        public const double PlanckDensity = 5.1551019e95;
        public static readonly double PlanckTemperatureToKelvin = PlanckTemperature;
        public static readonly double PlanckAreaToSquareMeter = PlanckArea;
        public static readonly double PlanckVolumeToCubicMeter = PlanckVolume;
        public static readonly double PlanckDensityToKilogramPerCubicMeter = PlanckDensity;
        public const double PlanckEnergy = 1.9561e9;
        public const double PlanckForce = 1.21027e44;
        public const double PlanckPressure = 4.63309e113;
        public const double PlanckVelocity = 1.85551e35;
        public const double PlanckAcceleration = 5.56284e51;
        public const double PlanckAngularFrequency = 3.33564e43;
        public const double PlanckAngularAcceleration = 2.411e61;
        public const double PlanckMomentum = 3.7038e-24;
    }
    public class SiPrefixes
    {
        public const double Yotta = 1e24;
        public const double Zetta = 1e21;
        public const double Exa = 1e18;
        public const double Peta = 1e15;
        public const double Tera = 1e12;
        public const double Giga = 1e9;
        public const double Mega = 1e6;
        public const double Kilo = 1e3;
        public const double Hecto = 1e2;
        public const double Deca = 1e1;
        public const double Deci = 1e-1;
        public const double Centi = 1e-2;
        public const double Milli = 1e-3;
        public const double Micro = 1e-6;
        public const double Nano = 1e-9;
        public const double Pico = 1e-12;
        public const double Femto = 1e-15;
        public const double Atto = 1e-18;
        public const double Zepto = 1e-21;
        public const double Yocto = 1e-24;
    }
    public class UnitConverter
    {
        // Conversion methods for Force/Weight units
        public static double ConvertForceWeight(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Pressure/Stress units
        public static double ConvertPressureStress(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Energy/Work/Heat units
        public static double ConvertEnergyWorkHeat(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Moment of Force units
        public static double ConvertMomentOfForce(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Angular Velocity/Frequency units
        public static double ConvertAngularVelocityFrequency(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Angular Acceleration units
        public static double ConvertAngularAcceleration(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Thermal Conductivity units
        public static double ConvertThermalConductivity(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Energy Density units
        public static double ConvertEnergyDensity(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Molar Energy units
        public static double ConvertMolarEnergy(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Catalytic Activity Concentration units
        public static double ConvertCatalyticActivityConcentration(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Electric Charge units
        public static double ConvertElectricCharge(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Capacitance units
        public static double ConvertCapacitance(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Resistance/Impedance/Reactance units
        public static double ConvertResistanceImpedanceReactance(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Electrical Conductance units
        public static double ConvertElectricalConductance(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Magnetic Flux units
        public static double ConvertMagneticFlux(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Absorbed Dose units
        public static double ConvertAbsorbedDose(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Equivalent Dose units
        public static double ConvertEquivalentDose(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Catalytic Activity units
        public static double ConvertCatalyticActivity(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Area units
        public static double ConvertArea(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Volume units
        public static double ConvertVolume(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Speed/Velocity units
        public static double ConvertSpeedVelocity(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Acceleration units
        public static double ConvertAcceleration(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Density units
        public static double ConvertDensity(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Luminance units
        public static double ConvertLuminance(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }

        // Conversion methods for Dynamic Viscosity units
        public static double ConvertDynamicViscosity(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }
        public static double ConvertTemperature(double value, double fromUnit, double toUnit)
        {
            if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return value + ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return value * ThermodynamicTemperatureUnits.Fahrenheit + ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return value * ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (ThermodynamicTemperatureUnits.AbsoluteZeroInDelisle - value) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return value * ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return value * ThermodynamicTemperatureUnits.Réaumur;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Kelvin && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return (value - ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) * ThermodynamicTemperatureUnits.Rømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return value - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return value * ThermodynamicTemperatureUnits.Fahrenheit + ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return (value + ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Fahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (100 - (value + ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius)) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return (value + ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return (value + ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Réaumur;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Celsius && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return ((value + ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Rømer) + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return (value - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit) / ThermodynamicTemperatureUnits.Fahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return (value - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit) / ThermodynamicTemperatureUnits.Fahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return value * ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (ThermodynamicTemperatureUnits.AbsoluteZeroInDelisle - ((value - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit) / ThermodynamicTemperatureUnits.Fahrenheit)) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return ((value - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit) / ThermodynamicTemperatureUnits.Fahrenheit) * ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return ((value - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit) / ThermodynamicTemperatureUnits.Fahrenheit) * ThermodynamicTemperatureUnits.Réaumur;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Fahrenheit && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return (((value - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit) / ThermodynamicTemperatureUnits.Fahrenheit) - ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) * ThermodynamicTemperatureUnits.Rømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return value / ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return (value / ThermodynamicTemperatureUnits.Rankine - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius);
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return value / ThermodynamicTemperatureUnits.Rankine * ThermodynamicTemperatureUnits.Fahrenheit - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (ThermodynamicTemperatureUnits.AbsoluteZeroInDelisle - ((value / ThermodynamicTemperatureUnits.Rankine) - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius)) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return ((value / ThermodynamicTemperatureUnits.Rankine - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Newton);
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return ((value / ThermodynamicTemperatureUnits.Rankine - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Réaumur);
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rankine && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return ((((value / ThermodynamicTemperatureUnits.Rankine - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Rømer) - ThermodynamicTemperatureUnits.AbsoluteZeroInRømer));
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return ThermodynamicTemperatureUnits.AbsoluteZeroInDelisle - (value * ThermodynamicTemperatureUnits.Delisle);
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return (100 - value) / ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return (100 - value) / ThermodynamicTemperatureUnits.Delisle * ThermodynamicTemperatureUnits.Fahrenheit - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return (ThermodynamicTemperatureUnits.AbsoluteZeroInDelisle - (value * ThermodynamicTemperatureUnits.Delisle)) * ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return ((100 - value) / ThermodynamicTemperatureUnits.Delisle) * ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return ((100 - value) / ThermodynamicTemperatureUnits.Delisle) * ThermodynamicTemperatureUnits.Réaumur;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Delisle && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return (((100 - value) / ThermodynamicTemperatureUnits.Delisle) * ThermodynamicTemperatureUnits.Rømer) - ThermodynamicTemperatureUnits.AbsoluteZeroInRømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return value / ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return (value / ThermodynamicTemperatureUnits.Newton - ThermodynamicTemperatureUnits.AbsoluteZeroInNewton) / ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return ((value / ThermodynamicTemperatureUnits.Newton - ThermodynamicTemperatureUnits.AbsoluteZeroInNewton) / ThermodynamicTemperatureUnits.Newton) * ThermodynamicTemperatureUnits.Fahrenheit - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return (value / ThermodynamicTemperatureUnits.Newton - ThermodynamicTemperatureUnits.AbsoluteZeroInNewton) * ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (100 - (value / ThermodynamicTemperatureUnits.Newton - ThermodynamicTemperatureUnits.AbsoluteZeroInNewton)) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return ((value / ThermodynamicTemperatureUnits.Newton - ThermodynamicTemperatureUnits.AbsoluteZeroInNewton) / ThermodynamicTemperatureUnits.Newton) * ThermodynamicTemperatureUnits.Réaumur;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Newton && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return (((value / ThermodynamicTemperatureUnits.Newton - ThermodynamicTemperatureUnits.AbsoluteZeroInNewton) / ThermodynamicTemperatureUnits.Newton) * ThermodynamicTemperatureUnits.Rømer) - ThermodynamicTemperatureUnits.AbsoluteZeroInRømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return value / ThermodynamicTemperatureUnits.Réaumur;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return (value / ThermodynamicTemperatureUnits.Réaumur - ThermodynamicTemperatureUnits.AbsoluteZeroInRéaumur);
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return ((value / ThermodynamicTemperatureUnits.Réaumur - ThermodynamicTemperatureUnits.AbsoluteZeroInRéaumur) / ThermodynamicTemperatureUnits.Réaumur) * ThermodynamicTemperatureUnits.Fahrenheit - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return (value / ThermodynamicTemperatureUnits.Réaumur - ThermodynamicTemperatureUnits.AbsoluteZeroInRéaumur) * ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (80 - (value / ThermodynamicTemperatureUnits.Réaumur - ThermodynamicTemperatureUnits.AbsoluteZeroInRéaumur)) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return ((value / ThermodynamicTemperatureUnits.Réaumur - ThermodynamicTemperatureUnits.AbsoluteZeroInRéaumur) / ThermodynamicTemperatureUnits.Réaumur) * ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Réaumur && toUnit == ThermodynamicTemperatureUnits.Rømer)
            {
                return (((value / ThermodynamicTemperatureUnits.Réaumur - ThermodynamicTemperatureUnits.AbsoluteZeroInRéaumur) / ThermodynamicTemperatureUnits.Réaumur) * ThermodynamicTemperatureUnits.Rømer) - ThermodynamicTemperatureUnits.AbsoluteZeroInRømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Kelvin)
            {
                return (value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Celsius)
            {
                return ((value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius);
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Fahrenheit)
            {
                return (((value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) / ThermodynamicTemperatureUnits.Rømer) * ThermodynamicTemperatureUnits.Fahrenheit - ThermodynamicTemperatureUnits.AbsoluteZeroInFahrenheit;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Rankine)
            {
                return ((value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) * ThermodynamicTemperatureUnits.Rankine;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Delisle)
            {
                return (60 - ((value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius)) * ThermodynamicTemperatureUnits.Delisle;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Newton)
            {
                return (((value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) / ThermodynamicTemperatureUnits.Rømer) * ThermodynamicTemperatureUnits.Newton;
            }
            else if (fromUnit == ThermodynamicTemperatureUnits.Rømer && toUnit == ThermodynamicTemperatureUnits.Réaumur)
            {
                return ((((value + ThermodynamicTemperatureUnits.AbsoluteZeroInRømer) / ThermodynamicTemperatureUnits.Rømer - ThermodynamicTemperatureUnits.AbsoluteZeroInCelsius) / ThermodynamicTemperatureUnits.Rømer) * ThermodynamicTemperatureUnits.Réaumur);
            }

            return value;
        }

        public static double ConvertSubunits(double value, double fromUnit, double toUnit)
        {
            return value * fromUnit / toUnit;
        }
    }
}