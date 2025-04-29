﻿using Enumeracoes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker( string name, double baseSalary, WorkerLevel level, Department department)
        {
            
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) { 
            Contracts.Remove(contract);
        }

        public double CalculateIncome(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) {
                if (year == contract.Date.Year && month == contract.Date.Month) { 
                    sum += contract.TotalValue();
                }
            }
            // Implementation for calculating income
            return sum;
        }
    }

}
