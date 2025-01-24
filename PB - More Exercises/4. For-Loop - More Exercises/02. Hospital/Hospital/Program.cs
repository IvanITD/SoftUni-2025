// User Input
int period = int.Parse(Console.ReadLine());
int patientsAmount = int.Parse(Console.ReadLine());

// The amount of doctors is always 7
int doctors = 7;

// Variable for the treated patients
int treatedPatients = 0;

// Variable for the untreated patients
int untreatedPatients = 0;

// Loop through the period
for (int i = 1; i <= period; i++)
{
    // Check if the period is divisible by 3
    if (i % 3 == 0)
    {
        // Check if the untreated patients are more than the treated patients
        if (untreatedPatients > treatedPatients)
        {
            // Increase the amount of doctors by 1
            doctors++;
        }
    }

    // Check if the patients are more than the doctors
    if (patientsAmount > doctors)
    {
        // Increase the treated patients by the amount of doctors
        treatedPatients += doctors;

        // Increase the untreated patients by the difference between the patients and the doctors
        untreatedPatients += patientsAmount - doctors;
    }
    else
    {
        // Increase the treated patients by the amount of patients
        treatedPatients += patientsAmount;
    }
}

// Print the treated patients
Console.WriteLine($"Treated patients: {treatedPatients}.");

// Print the untreated patients
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
