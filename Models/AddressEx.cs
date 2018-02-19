﻿using System.ComponentModel;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Amica.Models
{
    /// <summary>
    /// Extended address information.
    /// </summary>
    /// <seealso cref="Amica.Models.ObservableObject" />
    /// <seealso cref="Amica.Models.IAddress" />
    /// <seealso cref="Amica.Models.IContactDetails" />
    public class AddressEx : ObservableObject, IAddress, IContactDetails
    {
        private Address _address = new Address();
        private ContactDetails _contactDetails = new ContactDetails();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressEx"/> class.
        /// </summary>
        public AddressEx()
        {
			// TODO
			// Could use reflection to bind private object fields to OnInternalPropertyChanged
			// and we could do this in ObservableObject, so all OO can use composition without
			// explictly coding this boilerplate.
            _address.PropertyChanged += OnInternalObjectPropertyChanged;
            _contactDetails.PropertyChanged += OnInternalObjectPropertyChanged;

        }

        private void OnInternalObjectPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyPropertyChanged(e.PropertyName);
        }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Phone), ResourceType = typeof(Resources.PropertyNames))]
        public string Phone
        {
            get { return _contactDetails.Phone; }
            set { _contactDetails.Phone = value; }
        }
        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Mobile), ResourceType = typeof(Resources.PropertyNames))]
        public string Mobile
        {
            get { return _contactDetails.Mobile; }
            set { _contactDetails.Mobile = value; }
        }
        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        /// <value>
        /// The fax.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Fax), ResourceType = typeof(Resources.PropertyNames))]
        public string Fax
        {
            get { return _contactDetails.Fax; }
            set { _contactDetails.Fax = value; }
        }
        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        /// <value>
        /// The mail.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Mail), ResourceType = typeof(Resources.PropertyNames))]
        public string Mail
        {
            get { return _contactDetails.Mail; }
            set { _contactDetails.Mail = value; }
        }
        /// <summary>
        /// Gets or sets the PEC mail.
        /// </summary>
        /// <value>
        /// The PEC mail.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.PecMail), ResourceType = typeof(Resources.PropertyNames))]
        public string PecMail
        {
            get { return _contactDetails.PecMail; }
            set { _contactDetails.PecMail = value; }
        }
        /// <summary>
        /// Gets or sets the web site.
        /// </summary>
        /// <value>
        /// The web site.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.WebSite), ResourceType = typeof(Resources.PropertyNames))]
        public string WebSite
        {
            get { return _contactDetails.WebSite; }
            set { _contactDetails.WebSite = value; }
        }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Street), ResourceType = typeof(Resources.PropertyNames))]
        public string Street
        {
            get { return _address.Street; }
            set { _address.Street = value; }
        }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        /// <value>
        /// The town.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Town), ResourceType = typeof(Resources.PropertyNames))]
        public string Town
        {
            get { return _address.Town; }
            set { _address.Town = value; }
        }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.PostalCode), ResourceType = typeof(Resources.PropertyNames))]
        public string PostalCode
        {
            get { return _address.PostalCode; }
            set { _address.PostalCode = value; }
        }

        /// <summary>
        /// Gets or sets the state or province.
        /// </summary>
        /// <value>
        /// The state or province.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.StateOrProvince), ResourceType = typeof(Resources.PropertyNames))]
        public string StateOrProvince
        {
            get { return _address.StateOrProvince; }
            set { _address.StateOrProvince = value; }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Country), ResourceType = typeof(Resources.PropertyNames))]
        public string Country
        {
            get { return _address.Country; }
            set { _address.Country = value; }
        }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        [Display(Name = nameof(Resources.PropertyNames.Notes), ResourceType = typeof(Resources.PropertyNames))]
        public string Notes
        {
            get { return _address.Notes; }
            set { _address.Notes = value; }
        }

    }
}