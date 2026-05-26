using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work_Mishin
{
    public class Patient
    {
        /// <summary>
        /// ID пациента
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Полное имя пациента
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Возраст пациента
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Пол пациента
        /// </summary>
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// Диагноз пациента
        /// </summary>
        public string Disease { get; set; } = string.Empty;

        /// <summary>
        /// Тяжесть заболевания
        /// </summary>
        public string Severity { get; set; } = string.Empty;

        /// <summary>
        /// Продолжительность заболевания в днях
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Отделение больницы, в котором проходит лечение пациент
        /// </summary>
        public string Department { get; set; } = string.Empty;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Patient() { }
    }
}
