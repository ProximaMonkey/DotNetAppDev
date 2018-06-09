﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Метаданные связи EDM

[assembly: EdmRelationshipAttribute("EventRegistrationModel", "FK_Attendees_Events", "Events", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SilverlightDemos.Web.Event), "Attendees", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SilverlightDemos.Web.Attendee), true)]
[assembly: EdmRelationshipAttribute("EventRegistrationModel", "FK_RegistrationCodes_Events", "Events", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SilverlightDemos.Web.Event), "RegistrationCodes", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SilverlightDemos.Web.RegistrationCode), true)]

#endregion

namespace SilverlightDemos.Web
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class EventRegistrationEntities : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект EventRegistrationEntities, используя строку соединения из раздела "EventRegistrationEntities" файла конфигурации приложения.
        /// </summary>
        public EventRegistrationEntities() : base("name=EventRegistrationEntities", "EventRegistrationEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта EventRegistrationEntities.
        /// </summary>
        public EventRegistrationEntities(string connectionString) : base(connectionString, "EventRegistrationEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта EventRegistrationEntities.
        /// </summary>
        public EventRegistrationEntities(EntityConnection connection) : base(connection, "EventRegistrationEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Attendee> Attendees
        {
            get
            {
                if ((_Attendees == null))
                {
                    _Attendees = base.CreateObjectSet<Attendee>("Attendees");
                }
                return _Attendees;
            }
        }
        private ObjectSet<Attendee> _Attendees;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Event> Events
        {
            get
            {
                if ((_Events == null))
                {
                    _Events = base.CreateObjectSet<Event>("Events");
                }
                return _Events;
            }
        }
        private ObjectSet<Event> _Events;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<RegistrationCode> RegistrationCodes
        {
            get
            {
                if ((_RegistrationCodes == null))
                {
                    _RegistrationCodes = base.CreateObjectSet<RegistrationCode>("RegistrationCodes");
                }
                return _RegistrationCodes;
            }
        }
        private ObjectSet<RegistrationCode> _RegistrationCodes;

        #endregion

        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Attendees. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToAttendees(Attendee attendee)
        {
            base.AddObject("Attendees", attendee);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Events. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToEvents(Event @event)
        {
            base.AddObject("Events", @event);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet RegistrationCodes. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToRegistrationCodes(RegistrationCode registrationCode)
        {
            base.AddObject("RegistrationCodes", registrationCode);
        }

        #endregion

    }

    #endregion

    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EventRegistrationModel", Name="Attendee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Attendee : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Attendee.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="eventId">Исходное значение свойства EventId.</param>
        /// <param name="name">Исходное значение свойства Name.</param>
        public static Attendee CreateAttendee(global::System.Int32 id, global::System.Int32 eventId, global::System.String name)
        {
            Attendee attendee = new Attendee();
            attendee.Id = id;
            attendee.EventId = eventId;
            attendee.Name = name;
            return attendee;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EventId
        {
            get
            {
                return _EventId;
            }
            set
            {
                OnEventIdChanging(value);
                ReportPropertyChanging("EventId");
                _EventId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EventId");
                OnEventIdChanged();
            }
        }
        private global::System.Int32 _EventId;
        partial void OnEventIdChanging(global::System.Int32 value);
        partial void OnEventIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Company
        {
            get
            {
                return _Company;
            }
            set
            {
                OnCompanyChanging(value);
                ReportPropertyChanging("Company");
                _Company = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Company");
                OnCompanyChanged();
            }
        }
        private global::System.String _Company;
        partial void OnCompanyChanging(global::System.String value);
        partial void OnCompanyChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RegistrationCode
        {
            get
            {
                return _RegistrationCode;
            }
            set
            {
                OnRegistrationCodeChanging(value);
                ReportPropertyChanging("RegistrationCode");
                _RegistrationCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RegistrationCode");
                OnRegistrationCodeChanged();
            }
        }
        private global::System.String _RegistrationCode;
        partial void OnRegistrationCodeChanging(global::System.String value);
        partial void OnRegistrationCodeChanged();

        #endregion

    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EventRegistrationModel", "FK_Attendees_Events", "Events")]
        public Event Event
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("EventRegistrationModel.FK_Attendees_Events", "Events").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("EventRegistrationModel.FK_Attendees_Events", "Events").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Event> EventReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("EventRegistrationModel.FK_Attendees_Events", "Events");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Event>("EventRegistrationModel.FK_Attendees_Events", "Events", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EventRegistrationModel", Name="Event")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Event : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Event.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="name">Исходное значение свойства Name.</param>
        /// <param name="dateFrom">Исходное значение свойства DateFrom.</param>
        /// <param name="dateTo">Исходное значение свойства DateTo.</param>
        public static Event CreateEvent(global::System.Int32 id, global::System.String name, global::System.DateTime dateFrom, global::System.DateTime dateTo)
        {
            Event @event = new Event();
            @event.Id = id;
            @event.Name = name;
            @event.DateFrom = dateFrom;
            @event.DateTo = dateTo;
            return @event;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateFrom
        {
            get
            {
                return _DateFrom;
            }
            set
            {
                OnDateFromChanging(value);
                ReportPropertyChanging("DateFrom");
                _DateFrom = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateFrom");
                OnDateFromChanged();
            }
        }
        private global::System.DateTime _DateFrom;
        partial void OnDateFromChanging(global::System.DateTime value);
        partial void OnDateFromChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateTo
        {
            get
            {
                return _DateTo;
            }
            set
            {
                OnDateToChanging(value);
                ReportPropertyChanging("DateTo");
                _DateTo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateTo");
                OnDateToChanged();
            }
        }
        private global::System.DateTime _DateTo;
        partial void OnDateToChanging(global::System.DateTime value);
        partial void OnDateToChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EventRegistrationModel", "FK_Attendees_Events", "Attendees")]
        public EntityCollection<Attendee> Attendees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Attendee>("EventRegistrationModel.FK_Attendees_Events", "Attendees");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Attendee>("EventRegistrationModel.FK_Attendees_Events", "Attendees", value);
                }
            }
        }
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EventRegistrationModel", "FK_RegistrationCodes_Events", "RegistrationCodes")]
        public EntityCollection<RegistrationCode> RegistrationCodes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<RegistrationCode>("EventRegistrationModel.FK_RegistrationCodes_Events", "RegistrationCodes");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<RegistrationCode>("EventRegistrationModel.FK_RegistrationCodes_Events", "RegistrationCodes", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EventRegistrationModel", Name="RegistrationCode")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class RegistrationCode : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта RegistrationCode.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="eventId">Исходное значение свойства EventId.</param>
        /// <param name="registrationCode1">Исходное значение свойства RegistrationCode1.</param>
        public static RegistrationCode CreateRegistrationCode(global::System.Int32 id, global::System.Int32 eventId, global::System.String registrationCode1)
        {
            RegistrationCode registrationCode = new RegistrationCode();
            registrationCode.Id = id;
            registrationCode.EventId = eventId;
            registrationCode.RegistrationCode1 = registrationCode1;
            return registrationCode;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EventId
        {
            get
            {
                return _EventId;
            }
            set
            {
                OnEventIdChanging(value);
                ReportPropertyChanging("EventId");
                _EventId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EventId");
                OnEventIdChanged();
            }
        }
        private global::System.Int32 _EventId;
        partial void OnEventIdChanging(global::System.Int32 value);
        partial void OnEventIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RegistrationCode1
        {
            get
            {
                return _RegistrationCode1;
            }
            set
            {
                OnRegistrationCode1Changing(value);
                ReportPropertyChanging("RegistrationCode1");
                _RegistrationCode1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("RegistrationCode1");
                OnRegistrationCode1Changed();
            }
        }
        private global::System.String _RegistrationCode1;
        partial void OnRegistrationCode1Changing(global::System.String value);
        partial void OnRegistrationCode1Changed();

        #endregion

    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EventRegistrationModel", "FK_RegistrationCodes_Events", "Events")]
        public Event Event
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("EventRegistrationModel.FK_RegistrationCodes_Events", "Events").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("EventRegistrationModel.FK_RegistrationCodes_Events", "Events").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Event> EventReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Event>("EventRegistrationModel.FK_RegistrationCodes_Events", "Events");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Event>("EventRegistrationModel.FK_RegistrationCodes_Events", "Events", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}