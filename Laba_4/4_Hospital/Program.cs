﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Department> departments = new List<Department>();
            List<Doctor> doctorsAll = new List<Doctor>();

            var input = Console.ReadLine();
            while (input != "Output")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string dep = tokens[0];
                string dFn = tokens[1];
                string dLn = tokens[2];
                string pName = tokens[3];

                if (departments.Any(d => d.Name == dep))
                {
                    int depIndex = departments.IndexOf(departments.First(x => x.Name == dep));
                    int docIndex = 0;
                    if (DepartmentHasRoom(departments[depIndex]) == false)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (doctorsAll.Any(x => x.FirstName == dFn && x.LastName == dLn))
                    {
                        docIndex = doctorsAll.IndexOf(doctorsAll.First(x => x.FirstName == dFn && x.LastName == dLn));

                        doctorsAll[docIndex].Patients.Add(pName);
                    }
                    else
                    {
                        var newDoc = new Doctor(dFn, dLn);
                        newDoc.Patients.Add(pName);
                        doctorsAll.Add(newDoc);
                    }

                    for (int j = 0; j < departments[depIndex].Rooms.Count; j++)
                    {
                        if (departments[depIndex].Rooms[j].Patients.Count < 3)
                        {
                            departments[depIndex].Rooms[j].Patients.Add(pName);
                            break;
                        }
                    }
                }
                else
                {
                    var currentDep = new Department(dep);
                    Doctor doc = new Doctor(dFn, dLn);
                    doc.Patients.Add(pName);
                    doctorsAll.Add(doc);
                    currentDep.Rooms[0].Patients.Add(pName);
                    departments.Add(currentDep);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    var patients = new List<string>();
                    if (doctorsAll.Any(x => x.FirstName + " " + x.LastName == tokens[0] + " " + tokens[1]))
                    {
                        int docIndex = doctorsAll.IndexOf(doctorsAll.First(x => x.FirstName + " " + x.LastName == tokens[0] + " " + tokens[1]));

                        patients = doctorsAll[docIndex].Patients;

                        foreach (var p in patients.OrderBy(x => x))
                        {
                            Console.WriteLine(p);
                        }

                        input = Console.ReadLine();
                        continue;
                    }
                    var depName = tokens[0];
                    var roomNum = int.Parse(tokens[1]) - 1;

                    patients = departments.First(x => x.Name == depName).Rooms[roomNum].Patients;

                    foreach (var p in patients.OrderBy(x => x))
                    {
                        Console.WriteLine(p);
                    }
                }
                else
                {
                    var command = tokens[0];

                    if (departments.Any(x => x.Name == command))
                    {
                        int depIndex = departments.IndexOf(departments.First(x => x.Name == command));

                        var patients = departments[depIndex].Rooms.SelectMany(x => x.Patients);

                        foreach (var room in departments[depIndex].Rooms)
                        {
                            foreach (var p in room.Patients)
                            {
                                Console.WriteLine(p);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static bool DepartmentHasRoom(Department department)
        {
            if (department.Rooms.Sum(x => x.Patients.Count) < 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
