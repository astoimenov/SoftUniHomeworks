namespace P01Customer
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string address;
        private string mobilePhone;
        private string email;
        private ICollection<Payment> payments;
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, long id, string address, string email, string mobilePhone, ICollection<Payment> payments, CustomerType customerType)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.id = id;
            this.address = address;
            this.email = email;
            this.mobilePhone = mobilePhone;
            this.payments = payments;
            this.customerType = customerType;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't be empty!");
                }

                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can't be empty!");
                }

                this.middleName = value;
            }
        }

        public long Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ID can't be negative!");
                }

                this.id = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Address can't be empty!");
                }

                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Mobile phone can't be empty!");
                }

                const string PhonePattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
                if (!Regex.IsMatch(value, PhonePattern))
                {
                    throw new ArgumentException("Invalid phone!");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can't be empty!");
                }

                const string EmailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (!Regex.IsMatch(value, EmailPattern))
                {
                    throw new ArgumentException("Invalid email!");
                }

                this.email = value;
            }
        }

        public ICollection<Payment> Payments
        {
            get { return this.payments; }
            set { this.payments = value; }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set { this.customerType = value; }
        }

        public static bool operator ==(Customer customer, Customer otherCustomer)
        {
            return Equals(customer, otherCustomer);
        }

        public static bool operator !=(Customer customer, Customer otherCustomer)
        {
            return !Equals(customer, otherCustomer);
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer != null)
            {
                bool isFirstNameEqual = string.Equals(this.firstName, customer.firstName);
                bool isLastNameEqual = string.Equals(this.lastName, customer.lastName);
                bool isMiddleNameEqual = string.Equals(this.middleName, customer.middleName);
                bool isNameEqual = isFirstNameEqual && isMiddleNameEqual && isLastNameEqual;

                bool isIdEqual = this.id == customer.id;
                bool isAddressEqual = string.Equals(this.address, customer.address);
                bool isPhoneEqual = string.Equals(this.mobilePhone, customer.mobilePhone);
                bool isEmailEqual = string.Equals(this.email, customer.email);
                bool isPersInfoEqual = isIdEqual && isAddressEqual && isPhoneEqual && isEmailEqual;

                bool isPaymentsEqual = this.payments == customer.payments;
                bool isTypeEqual = Equals(this.customerType, customer.customerType);
                bool isCustomerInfoEqual = isPaymentsEqual && isTypeEqual;

                if (isNameEqual && isPersInfoEqual && isCustomerInfoEqual)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public override int GetHashCode()
        {
            PropertyInfo[] theProperties = this.GetType().GetProperties();
            int hash = 31;
            foreach (PropertyInfo info in theProperties)
            {
                if (info != null)
                {
                    var value = info.GetValue(this, null);
                    if (value != null)
                    {
                        unchecked
                        {
                            hash = 29 * hash ^ value.GetHashCode();
                        }
                    }
                }
            }

            return hash;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("{0} customer:", this.customerType));
            output.AppendLine(string.Format(
                "Name: {0} {1} {2}; ID: {3}", 
                this.firstName,
                this.middleName,
                this.lastName,
                this.id));
            output.AppendLine(string.Format(
                "Address: {0}; Phone: {1}; E-mail: {2}",
                this.address,
                this.mobilePhone,
                this.email));
            output.AppendLine("Payments: ");
            foreach (Payment payment in this.payments)
            {
                output.AppendLine(payment.ToString());
            }

            return output.ToString();
        }

        public object Clone()
        {
            Customer clonedCustomer = new Customer(
                this.firstName,
                this.middleName,
                this.lastName,
                this.id,
                this.address,
                this.email,
                this.mobilePhone,
                this.payments,
                this.customerType);
            return clonedCustomer;
        }

        public int CompareTo(Customer other)
        {
            string thisFullName = this.firstName + " " + this.middleName + " " + this.lastName;
            string otherFullName = other.firstName + " " + other.middleName + " " + other.lastName;
            if (thisFullName.CompareTo(otherFullName) == 0)
            {
                return this.id.CompareTo(other.id);
            }

            return thisFullName.CompareTo(otherFullName);
        }
    }
}
