﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mini.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Training_19Sep18_PuneEntities1 : DbContext
    {
        public Training_19Sep18_PuneEntities1()
            : base("name=Training_19Sep18_PuneEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TicketDetails> TicketDetails { get; set; }
    
        public virtual int TicketAction(Nullable<int> id, Nullable<bool> action)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var actionParameter = action.HasValue ?
                new ObjectParameter("action", action) :
                new ObjectParameter("action", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TicketAction", idParameter, actionParameter);
        }
    }
}
