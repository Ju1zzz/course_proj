//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace course_project.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;

    public partial class GuildsEntities : DbContext
    {
        public GuildsEntities()
            : base("name=GuildsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Guild> Guild { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<Modification> Modification { get; set; }
        public DbSet<Part> Part { get; set; }
    
        public virtual ObjectResult<AutoDraft_Result> AutoDraft(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AutoDraft_Result>("AutoDraft", rowsParameter);
        }
    
        public virtual int AutoGuild(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoGuild", rowsParameter);
        }
    
        public virtual int AutoMachine(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoMachine", rowsParameter);
        }
    
        public virtual int AutoModification(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoModification", rowsParameter);
        }
    
        public virtual int AutoPart(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoPart", rowsParameter);
        }
    
        public virtual ObjectResult<AutoProcessing_Result> AutoProcessing(Nullable<int> rows)
        {
            var rowsParameter = rows.HasValue ?
                new ObjectParameter("rows", rows) :
                new ObjectParameter("rows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AutoProcessing_Result>("AutoProcessing", rowsParameter);
        }
    
        public virtual int DeleteDraft(Nullable<int> id_m, Nullable<int> id_p)
        {
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDraft", id_mParameter, id_pParameter);
        }
    
        public virtual int DeleteGuild(Nullable<int> id_g)
        {
            var id_gParameter = id_g.HasValue ?
                new ObjectParameter("id_g", id_g) :
                new ObjectParameter("id_g", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteGuild", id_gParameter);
        }
    
        public virtual int DeleteMachine(Nullable<int> id_m)
        {
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMachine", id_mParameter);
        }
    
        public virtual int DeleteMod(Nullable<int> id_m)
        {
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteMod", id_mParameter);
        }
    
        public virtual int DeletePart(Nullable<int> id_p)
        {
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePart", id_pParameter);
        }
    
        public virtual int DeleteProcessing(Nullable<int> id_p, Nullable<int> id_m)
        {
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProcessing", id_pParameter, id_mParameter);
        }
    
        public virtual ObjectResult<Everything_Result> Everything()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Everything_Result>("Everything");
        }
    
        public virtual ObjectResult<FirstDoc_Result> FirstDoc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FirstDoc_Result>("FirstDoc");
        }
    
        public virtual int InsertDraft(Nullable<int> id_m, Nullable<int> id_p)
        {
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDraft", id_mParameter, id_pParameter);
        }
    
        public virtual int InsertGuild(string name, string firm)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var firmParameter = firm != null ?
                new ObjectParameter("firm", firm) :
                new ObjectParameter("firm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertGuild", nameParameter, firmParameter);
        }
    
        public virtual int InsertMachine(Nullable<int> guild, string firm, Nullable<double> time)
        {
            var guildParameter = guild.HasValue ?
                new ObjectParameter("Guild", guild) :
                new ObjectParameter("Guild", typeof(int));
    
            var firmParameter = firm != null ?
                new ObjectParameter("Firm", firm) :
                new ObjectParameter("Firm", typeof(string));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("Time", time) :
                new ObjectParameter("Time", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMachine", guildParameter, firmParameter, timeParameter);
        }
    
        public virtual int InsertMod(string name, Nullable<double> labour)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var labourParameter = labour.HasValue ?
                new ObjectParameter("labour", labour) :
                new ObjectParameter("labour", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMod", nameParameter, labourParameter);
        }
    
        public virtual int InsertPart(string name, string firm)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var firmParameter = firm != null ?
                new ObjectParameter("firm", firm) :
                new ObjectParameter("firm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPart", nameParameter, firmParameter);
        }
    
        public virtual int InsertProcessing(Nullable<int> id_p, Nullable<int> id_m)
        {
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProcessing", id_pParameter, id_mParameter);
        }
    
        public virtual ObjectResult<string> SecondDoc(Nullable<int> id_g, string letter)
        {
            var id_gParameter = id_g.HasValue ?
                new ObjectParameter("id_g", id_g) :
                new ObjectParameter("id_g", typeof(int));
    
            var letterParameter = letter != null ?
                new ObjectParameter("letter", letter) :
                new ObjectParameter("letter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SecondDoc", id_gParameter, letterParameter);
        }
    
        public virtual ObjectResult<ShowDrafts_Result> ShowDrafts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowDrafts_Result>("ShowDrafts");
        }
    
        public virtual ObjectResult<ShowGuild_Result> ShowGuild()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowGuild_Result>("ShowGuild");
        }
    
        public virtual ObjectResult<ShowMachine_Result> ShowMachine()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowMachine_Result>("ShowMachine");
        }
    
        public virtual ObjectResult<ShowMods_Result> ShowMods()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowMods_Result>("ShowMods");
        }
    
        public virtual ObjectResult<ShowPart_Result> ShowPart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowPart_Result>("ShowPart");
        }
    
        public virtual ObjectResult<ShowProcessing_Result> ShowProcessing()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowProcessing_Result>("ShowProcessing");
        }
    
        public virtual int UpdateDraft(Nullable<int> id_p, Nullable<int> id_m)
        {
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDraft", id_pParameter, id_mParameter);
        }
    
        public virtual int UpdateGuild(Nullable<int> id, string name, string firm)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var firmParameter = firm != null ?
                new ObjectParameter("firm", firm) :
                new ObjectParameter("firm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateGuild", idParameter, nameParameter, firmParameter);
        }
    
        public virtual int UpdateMachine(Nullable<int> id, Nullable<double> time, string firm, Nullable<int> id_g)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var timeParameter = time.HasValue ?
                new ObjectParameter("time", time) :
                new ObjectParameter("time", typeof(double));
    
            var firmParameter = firm != null ?
                new ObjectParameter("firm", firm) :
                new ObjectParameter("firm", typeof(string));
    
            var id_gParameter = id_g.HasValue ?
                new ObjectParameter("id_g", id_g) :
                new ObjectParameter("id_g", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMachine", idParameter, timeParameter, firmParameter, id_gParameter);
        }
    
        public virtual int UpdateMod(Nullable<int> id, string name, Nullable<double> labour)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var labourParameter = labour.HasValue ?
                new ObjectParameter("labour", labour) :
                new ObjectParameter("labour", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMod", idParameter, nameParameter, labourParameter);
        }
    
        public virtual int UpdatePart(Nullable<int> id, string name, string firm)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var firmParameter = firm != null ?
                new ObjectParameter("firm", firm) :
                new ObjectParameter("firm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePart", idParameter, nameParameter, firmParameter);
        }
    
        public virtual int UpdateProcessing(Nullable<int> id_p, Nullable<int> id_m)
        {
            var id_pParameter = id_p.HasValue ?
                new ObjectParameter("id_p", id_p) :
                new ObjectParameter("id_p", typeof(int));
    
            var id_mParameter = id_m.HasValue ?
                new ObjectParameter("id_m", id_m) :
                new ObjectParameter("id_m", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProcessing", id_pParameter, id_mParameter);
        }
    
        public virtual ObjectResult<FirstDoc_Result> first()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FirstDoc_Result>("first");
        }
    }
}
