//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Family
    {
        public int ID { get; set; }
        public Nullable<int> FK_sotrudnik { get; set; }
        public string FIO { get; set; }
        public string stepen_rodstva { get; set; }
        public Nullable<System.DateTime> data_rojdeniya { get; set; }
    
        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}