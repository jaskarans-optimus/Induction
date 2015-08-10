using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCusingWinForms.Views;
namespace MVCusingWinForms.Models
{
    public class SystemModel
    {
        private ArrayList views = new ArrayList();
        public SystemModel(string name, float minRam, float minDisk, float CpuSpeed)
        {
            MinRam = minRam;
            MinDisk = minDisk;
            this.CpuSpeed = CpuSpeed;
            Name = name;
            Ram = minRam;
            Disk = minDisk;
            
        }
        public string Name { get; set; }
        public float Ram { get; set; }
        public float Disk { get; set; }
        public float MinRam { get; set; }
        public float MinDisk { get; set; }
        public float CpuSpeed { get; set; }
        public void UpdateModel(float ram, float disk, float cpuSpeed)
        {
            Ram += ram;
            Disk += disk;
            CpuSpeed += cpuSpeed;
            this.NotifyObservers();
        }
        public void AddObserver(SystemView view)
        {
            views.Add(view);
        }
        public void RemoveObserver(SystemView view)
        {
            views.Remove(view);
        }
        public void NotifyObservers()
        {
            foreach (SystemView view in views)
            {
                view.Update(this);
            }
        }
    }

}