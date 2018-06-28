﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataMetrics
    {
        public int id { get; set; }
        public string value { get; set; }
        public int idMetric { get; set; }
    
        public virtual Metrics Metrics { get; set; }
    }
}
namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeviceEmployees
    {
        public int id { get; set; }
        public Nullable<int> idDevice { get; set; }
        public Nullable<int> idEmployee { get; set; }
    
        public virtual Devices Devices { get; set; }
        public virtual Employees Employees { get; set; }
    }
}
namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Devices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Devices()
        {
            this.DeviceEmployees = new HashSet<DeviceEmployees>();
            this.Metrics = new HashSet<Metrics>();
            this.HistoriqueCommandes = new HashSet<HistoriqueCommandes>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string adressMac { get; set; }
        public Nullable<int> idTypeDevice { get; set; }
        public string description { get; set; }
        public Nullable<bool> disabled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceEmployees> DeviceEmployees { get; set; }
        public virtual TypeDevices TypeDevices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Metrics> Metrics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoriqueCommandes> HistoriqueCommandes { get; set; }
    }
}
namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.DeviceEmployees = new HashSet<DeviceEmployees>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceEmployees> DeviceEmployees { get; set; }
    }
}
namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoriqueCommandes
    {
        public int id { get; set; }
        public string commandeName { get; set; }
        public Nullable<int> idDevice { get; set; }
        public Nullable<System.DateTime> dateTime { get; set; }
    
        public virtual Devices Devices { get; set; }
    }
}
namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Metrics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Metrics()
        {
            this.DataMetrics = new HashSet<DataMetrics>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> nbrValues { get; set; }
        public Nullable<int> idDevice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataMetrics> DataMetrics { get; set; }
        public virtual Devices Devices { get; set; }
    }
}
namespace AdoModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeDevices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeDevices()
        {
            this.Devices = new HashSet<Devices>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devices> Devices { get; set; }
    }
}
