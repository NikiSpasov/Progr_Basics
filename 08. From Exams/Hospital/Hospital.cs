using System;
class Hospital
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int servedPatients = 0;
        int unservedPatients = 0;
        int docs = 7;
        int finalPatient = 0;
        int finalUntreated = 0;
        for (int i = 1; i <= days; i++)
        {
            int patients = int.Parse(Console.ReadLine());
            if (i % 3 == 0 && finalPatient < finalUntreated)
            {
                docs++;
            }
            if (patients <= docs)
            {
                servedPatients = patients;
                unservedPatients = 0;
            }
            else if (patients > docs)
            {
                servedPatients = docs;
                unservedPatients = patients - docs;
            }
            finalPatient += servedPatients;
            finalUntreated += unservedPatients;
            
        }
        Console.WriteLine("Treated patients: {0}.", finalPatient);
        Console.WriteLine("Untreated patients: {0}.", finalUntreated);
    }
}