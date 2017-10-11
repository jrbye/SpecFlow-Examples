﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("BookShopModel", "FK_OrderLines_Books", "Book", RelationshipMultiplicity.One, typeof(BookShop.Models.Book), "OrderLines", RelationshipMultiplicity.Many, typeof(BookShop.Models.OrderLine), true)]
[assembly: EdmRelationshipAttribute("BookShopModel", "FK_OrderLines_Orders", "Orders", RelationshipMultiplicity.One, typeof(BookShop.Models.Order), "OrderLines", RelationshipMultiplicity.Many, typeof(BookShop.Models.OrderLine), true)]

#endregion

namespace BookShop.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class BookShopEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new BookShopEntities object using the connection string found in the 'BookShopEntities' section of the application configuration file.
        /// </summary>
        public BookShopEntities() : base("name=BookShopEntities", "BookShopEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BookShopEntities object.
        /// </summary>
        public BookShopEntities(string connectionString) : base(connectionString, "BookShopEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BookShopEntities object.
        /// </summary>
        public BookShopEntities(EntityConnection connection) : base(connection, "BookShopEntities")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderLine> OrderLines
        {
            get
            {
                if ((_OrderLines == null))
                {
                    _OrderLines = base.CreateObjectSet<OrderLine>("OrderLines");
                }
                return _OrderLines;
            }
        }
        private ObjectSet<OrderLine> _OrderLines;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderLines EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderLines(OrderLine orderLine)
        {
            base.AddObject("OrderLines", orderLine);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookShopModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        public static Book CreateBook(global::System.Int32 id, global::System.String author, global::System.String title, global::System.Decimal price)
        {
            Book book = new Book();
            book.Id = id;
            book.Author = author;
            book.Title = title;
            book.Price = price;
            return book;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
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
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false, "Author");
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value, "Price");
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Books", "OrderLines")]
        public EntityCollection<OrderLine> OrderLines
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Books", "OrderLines");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Books", "OrderLines", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookShopModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        public static Order CreateOrder(global::System.Int32 id, global::System.Decimal price, global::System.String status)
        {
            Order order = new Order();
            order.Id = id;
            order.Price = price;
            order.Status = status;
            return order;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
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
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value, "Price");
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, false, "Status");
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Orders", "OrderLines")]
        public EntityCollection<OrderLine> OrderLines
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Orders", "OrderLines");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Orders", "OrderLines", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookShopModel", Name="OrderLine")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderLine : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrderLine object.
        /// </summary>
        /// <param name="bookId">Initial value of the BookId property.</param>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="quantity">Initial value of the Quantity property.</param>
        public static OrderLine CreateOrderLine(global::System.Int32 bookId, global::System.Int32 orderId, global::System.Int32 quantity)
        {
            OrderLine orderLine = new OrderLine();
            orderLine.BookId = bookId;
            orderLine.OrderId = orderId;
            orderLine.Quantity = quantity;
            return orderLine;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BookId
        {
            get
            {
                return _BookId;
            }
            set
            {
                if (_BookId != value)
                {
                    OnBookIdChanging(value);
                    ReportPropertyChanging("BookId");
                    _BookId = StructuralObject.SetValidValue(value, "BookId");
                    ReportPropertyChanged("BookId");
                    OnBookIdChanged();
                }
            }
        }
        private global::System.Int32 _BookId;
        partial void OnBookIdChanging(global::System.Int32 value);
        partial void OnBookIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if (_OrderId != value)
                {
                    OnOrderIdChanging(value);
                    ReportPropertyChanging("OrderId");
                    _OrderId = StructuralObject.SetValidValue(value, "OrderId");
                    ReportPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
        }
        private global::System.Int32 _OrderId;
        partial void OnOrderIdChanging(global::System.Int32 value);
        partial void OnOrderIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                OnQuantityChanging(value);
                ReportPropertyChanging("Quantity");
                _Quantity = StructuralObject.SetValidValue(value, "Quantity");
                ReportPropertyChanged("Quantity");
                OnQuantityChanged();
            }
        }
        private global::System.Int32 _Quantity;
        partial void OnQuantityChanging(global::System.Int32 value);
        partial void OnQuantityChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Books", "Book")]
        public Book Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book> BookReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Orders", "Orders")]
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
