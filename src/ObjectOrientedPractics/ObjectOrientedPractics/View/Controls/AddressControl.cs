using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле адреса.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Поле для проверки заполнения почтового индекса.
        /// </summary>
        private bool _isValidPostIndex = false;

        /// <summary>
        /// Поле для проверки заполнения страны.
        /// </summary>
        private bool _isValidCountry = false;

        /// <summary>
        /// Поле для проверки заполнения города.
        /// </summary>
        private bool _isValidCity = false;

        /// <summary>
        /// Поле для проверки заполнения улицы.
        /// </summary>
        private bool _isValidStreet = false;

        /// <summary>
        /// Поле для проверки заполнения номера строения.
        /// </summary>
        private bool _isValidBuilding = false;

        /// <summary>
        /// Поле для проверки заполнения номера квартиры.
        /// </summary>
        private bool _isValidApartment = false;

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                PostIndexTextBox.Text = value.Index.ToString();
                CountryTextBox.Text = value.Country;
                CityTextBox.Text = value.City;
                StreetTextBox.Text = value.Street;
                BuildingTextBox.Text = value.Building;
                ApartmentTextBox.Text = value.Apartment;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ApartmentTextBox.Text))
                {
                    _address.Apartment = ApartmentTextBox.Text;
                    ApartmentTextBox.BackColor = Color.White;
                    ExceptionToolTip.SetToolTip(ApartmentTextBox, null);
                    _isValidApartment = true;
                }
            }
            catch (ArgumentException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов!");
                _isValidApartment = false;
            }

            catch (FormatException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(ApartmentTextBox, "Не более 10 символов!");
                _isValidApartment = false;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(BuildingTextBox.Text))
                {
                    _address.Building = BuildingTextBox.Text;
                    BuildingTextBox.BackColor = Color.White;
                    ExceptionToolTip.SetToolTip(BuildingTextBox, null);
                    _isValidBuilding = true;
                }
            }
            catch (ArgumentException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов!");
                _isValidBuilding = false;
            }

            catch (FormatException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(BuildingTextBox, "Не более 10 символов!");
                _isValidBuilding = false;
            }
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(PostIndexTextBox.Text) &
                    int.TryParse(PostIndexTextBox.Text, out var number))
                {
                    _address.Index = number;
                    PostIndexTextBox.BackColor = Color.White;
                    ExceptionToolTip.SetToolTip(PostIndexTextBox, null);
                    _isValidPostIndex = true;
                }
            }
            catch (ArgumentException)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(PostIndexTextBox, "Шестизначное число!");
                _isValidPostIndex = false;
            }

            catch (FormatException)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(PostIndexTextBox, "Шестизначное число!");
                _isValidPostIndex = false;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(StreetTextBox.Text))
                {
                    _address.Street = StreetTextBox.Text;
                    StreetTextBox.BackColor = Color.White;
                    ExceptionToolTip.SetToolTip(StreetTextBox, null);
                    _isValidStreet = true;
                }
            }
            catch (ArgumentException)
            {
                StreetTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(StreetTextBox, "Не более 100 символов!");
                _isValidStreet = false;
            }

            catch (FormatException)
            {
                StreetTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(StreetTextBox, "Не более 100 символов!");
                _isValidStreet = false;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CountryTextBox.Text))
                {
                    _address.Country = CountryTextBox.Text;
                    CountryTextBox.BackColor = Color.White;
                    ExceptionToolTip.SetToolTip(CountryTextBox, null);
                    _isValidCountry = true;
                }
            }
            catch (ArgumentException)
            {
                CountryTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(CountryTextBox, "Не более 50 символов!");
                _isValidCountry = false;
            }

            catch (FormatException)
            {
                CountryTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(CountryTextBox, "Не более 50 символов!");
                _isValidCountry = false;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CityTextBox.Text))
                {
                    _address.City = CityTextBox.Text;
                    CityTextBox.BackColor = Color.White;
                    ExceptionToolTip.SetToolTip(CityTextBox, null);
                    _isValidCity = true;
                }
            }
            catch (ArgumentException)
            {
                CityTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(CityTextBox, "Не более 50 символов!");
                _isValidCity = false;
            }

            catch (FormatException)
            {
                CityTextBox.BackColor = Color.LightPink;
                ExceptionToolTip.SetToolTip(CityTextBox, "Не более 50 символов!");
                _isValidCity = false;
            }
        }

        /// <summary>
        /// Функция очистки значений всех <see cref="TextBoxBase"/>.
        /// </summary>
        public void AddressClear()
        {
            PostIndexTextBox.Clear();
            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Функция проверки на введённость значений в <see cref="TextBoxBase"/>.
        /// </summary>
        /// <returns>True - не введены. False - введены. </returns>
        public bool AddressIsNullOrEmpty()
        {
            if (!string.IsNullOrEmpty(PostIndexTextBox.Text) & !string.IsNullOrEmpty(CountryTextBox.Text)
                & !string.IsNullOrEmpty(CityTextBox.Text) & !string.IsNullOrEmpty(StreetTextBox.Text)
                & !string.IsNullOrEmpty(BuildingTextBox.Text) & !string.IsNullOrEmpty(ApartmentTextBox.Text))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Проверка на правильность введённых данных.
        /// </summary>
        /// <returns>True - всё введено правильно. False - неправильно введены.</returns>
        public bool IsValidAddress()
        {
            if (_isValidApartment & _isValidBuilding & _isValidCity & _isValidCountry & _isValidPostIndex & _isValidStreet)
            {
                return true;
            }
            return false;
        }
    }
}
