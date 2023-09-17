CReated by @CodeAnarchist

# Units Conversion Library

This library provides methods to convert various physical units of measurement, including force, pressure, energy, temperature, and many more. It defines constants for different unit conversions and provides methods to perform these conversions.

## Supported Units

### Force and Weight Units
- Newton (N)
- Dyne (dyn)
- Kilopond (kp)
- Pound-Force (lbf)
- Poundal (pdl)

### Pressure and Stress Units
- Pascal (Pa)
- Pound-Force per Square Foot (lbf/ft²)
- Pound-Force per Square Inch (psi)
- Ounce-Force per Square Inch (ozf/in²)
- Inch Water Column (inWC)
- Millimeter of Water Column (mmWC)
- Centimeter of Water Column (cmWC)
- Meter of Water Column (mWC)
- Millimeter of Mercury (mmHg)
- Centimeter of Mercury (cmHg)
- Meter of Mercury (mHg)
- Atmosphere (atm)
- Bar (bar)
- Torr (Torr)

### Energy, Work, and Heat Units
- Calorie (cal)
- Joule (J)
- Kilowatt-Hour (kWh)
- Kilowatt-Minute (kWm)
- Therm (Therms)
- Electronvolt (eV)
- TNT Equivalent Ton (TNT ton)

### Moment of Force Units
- Newton-Meter (Nm)
- Pound-Force Foot (lbf·ft)
- Ounce-Force Inch (ozf·in)

### Angular Velocity and Frequency Units
- Hertz (Hz)
- Radian per Second (rad/s)
- Degree per Second (°/s)
- Grad per Second (grad/s)
- Radian per Hour (rad/h)
- Degree per Hour (°/h)
- Grad per Hour (grad/h)
- Binary Degree per Second (binary°/s)

### Angular Acceleration Units
- Radian per Second Squared (rad/s²)
- Degree per Second Squared (°/s²)
- Grad per Second Squared (grad/s²)
- Radian per Hour Squared (rad/h²)
- Degree per Hour Squared (°/h²)
- Grad per Hour Squared (grad/h²)

### Thermal Conductivity Units
- Watt per Meter-Kelvin (W/(m·K))
- British Thermal Unit (BTU)
- R-Value (R)
- U-Value (U)
- Tog (tog)
- Clo (clo)

### Energy Density Units
- Joule per Cubic Meter (J/m³)
- Joule per Liter (J/L)
- Watt-Hour per Liter (Wh/L)

### Molar Energy Units
- Kilocalories per Mole (kcal/mol)
- Electronvolts per Particle (eV/particle)
- Wavenumbers per Centimeter (cm⁻¹)
- Joule per Mole (J/mol)

### Catalytic Activity Concentration Units
- Turnover Frequency (TOF)
- Turnover Number (TON)
- Katal (kat)

### Electric Charge Units
- Coulomb (C)
- Elementary Charge (e)

### Capacitance Units
- Farad (F)
- Abfarad (abF)
- Statfarad (statF)

### Resistance, Impedance, and Reactance Units
- Ohm (Ω)
- Absolute Foot per Second (absft/s)
- Thomson Unit (Thomson)
- Jacobi Copper Unit (JCU)
- Webers Absolute Unit (Wb/abs)
- Siemens Mercury Unit (S/cm)
- British Association Ohm (BAΩ)
- Digney-Breguet Swiss Ohm (D-B Ω)
- Matthiessen (Matthiessen)
- Varley (Varley)
- German Mile (gmile)
- Abohm (abΩ)
- Statohm (statΩ)

### Electrical Conductance Units
- Mho (℧)
- Siemens (S)

### Magnetic Flux Units
- Weber (Wb)
- Maxwell (Mx)

### Absorbed Dose Units
- Gray (Gy)
- Rad (rad)

### Equivalent Dose Units
- Sievert (Sv)
- Roentgen Equivalent in Sieverts (rem)

### Catalytic Activity Units
- Turnover Frequency (TOF)
- Turnover Number (TON)

### Area Units
- Square Meter (m²)
- Square Foot (ft²)
- Square Yard (yd²)
- Square Mile (mi²)
- Square Inch (in²)
- Square Hectare (hectare)
- Square Acre (acre)
- Square Barn (barn)

### Volume Units
- Cubic Meter (m³)
- Liter (L)
- Cubic Inch (in³)
- Cubic Foot (ft³)
- Cubic Yard (yd³)
- Acre-Foot (acre-ft)
- Cubic Mile (mi³)
- Minim (min)
- Drachm (drachm)
- Fluid Ounce (fl oz)
- Pint (pt)
- Teaspoon (tsp)
- Tablespoon (tbsp)
- Gill (gill)
- Quart (qt)
- Gallon (gal)
- Barrel (barrel)
- Cord (cord)
- Peck (peck)
- Bushel (bu)
- Hogshead (hogshead)

### Speed and Velocity Units
- Meter per Second (m/s)
- Kilometer per Hour (km/h)
- Mile per Hour (mph)
- Knot (knot)
- Feet per Second (ft/s)
- Mach Number (Mach)
- Natural Unit of Speed (c)

### Acceleration Units
- Meter per Second Squared (m/s²)
- Gal (Gal)
- Feet per Second Squared (ft/s²)
- g₀ (standard gravity)

### Density Units
- Kilogram per Liter (kg/L)
- Gram per Milliliter (g/mL)
- Tonne per Cubic Meter (t/m³)
- Kilogram per Cubic Decimeter (kg/dm³)
- Gram per Cubic Centimeter (g/cm³)
- Megagram per Cubic Meter (Mg/m³)
- Avoirdupois Ounce per Cubic Inch (oz/³)
- Avoirdupois Ounce per Fluid Ounce (oz/US fl oz)
- Avoirdupois Pound per Cubic Inch (lb/³)
- Pound per Cubic Foot (lb/ft³)
- Pound per Cubic Yard (lb/yd³)
- Pound per US Liquid Gallon (lb/US gal)
- Pound per US Bushel (lb/US bu)
- Slug per Cubic Foot (slug/ft³)

### Luminance Units
- Candela per Square Meter (cd/m²)
- Stilb (Sb)
- Apostilb (asb)
- Bril (bril)
- Skot (sk)
- Lambert (L)
- Foot-Lambert (ft-L)
- Femtolambert (fL)

### Dynamic Viscosity Units
- Square Meter per Second (m²/s)
- Poise (P)
- Centipoise (cP)
- Stokes (St)
- Pound-Force Second per Square Foot (lb·ft/s/ft²)
- Square Feet per Second (ft²/s)
- Reyn (Reyn)
- Rhe (Rhe)

### Thermodynamic Temperature Units
- Kelvin (K)
- Celsius (°C)
- Fahrenheit (°F)
- Rankine (°R)
- Delisle (°De)
- Newton (°N)
- Réaumur (°Ré)
- Rømer (°Rø)

### Adding Custom Units
If you want to extend this collection of units by adding your own custom units, you can do so by following these steps:

Define Constants: Define constants for your custom units, similar to how the existing units are defined. Ensure that you accurately specify the conversion ratios relative to a base unit or a commonly used unit.

Create Conversion Methods: Add methods to the relevant classes (e.g., ForceWeightUnits, PressureStressUnits, etc.) to convert between your custom units and the base units. You can use existing conversion methods as templates for creating new ones.

Testing: Make sure to test your new units and conversion methods thoroughly to ensure they work as expected.

Pull Request: Once you have implemented your custom units and tested them successfully, consider making a pull request to contribute them to this collection. Please provide clear documentation and explanations for your additions.

## Advanced Usage and Examples

While the Units Converter provides straightforward unit conversions, it also offers advanced capabilities for handling more complex scenarios.


Converting between Units
The library provides conversion methods for various unit categories. Below are examples of how to use these methods:

Converting Force and Weight Units
'''
double newtons = UnitsConverter.ConvertForceWeight(1.0, ForceWeightUnits.PoundForce, ForceWeightUnits.Newton);'''
Converting Pressure and Stress Units
'''
double pascals = UnitsConverter.ConvertPressureStress(1.0, PressureStressUnits.PoundForcePerSquareInch, PressureStressUnits.Pascal);'''
Converting Energy, Work, and Heat Units
'''
double joules = UnitsConverter.ConvertEnergyWorkHeat(1.0, EnergyWorkHeatUnits.KilowattHour, EnergyWorkHeatUnits.Joule);'''
Converting Temperature Units
'''
double celsius = UnitsConverter.ConvertTemperature(32.0, ThermodynamicTemperatureUnits.Fahrenheit, ThermodynamicTemperatureUnits.Celsius);'''
To convert between other units, simply replace the source and target units in the conversion method calls.

Submultiple Conversion
The library also supports submultiple conversion for some units. For example, to convert from millimeters to meters:

'''
double meters = UnitsConverter.ConvertSubmultiple(1000.0, SubmultipleUnits.Millimeter, SubmultipleUnits.Meter);'''



Feel free to use this library to perform unit conversions in your applications, saving you the hassle of manually calculating conversion factors.