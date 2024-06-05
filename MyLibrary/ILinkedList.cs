using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal interface ILinkedList
    {
        /// <summary>
        /// Додає еелмент в початок списка
        /// </summary>
        /// <param name="value"></param>
        void AddFirst(short value);
        /// <summary>
        /// Повертає індекс елемента кратного 3
        /// </summary>
        /// <returns></returns>
        int GetNumberBy3();
        /// <summary>
        /// Повертає добуток елементів менишх за середнє арифметичне елементів списка
        /// </summary>
        /// <returns></returns>
        long ProductOfElementsLessThanAverage();
        /// <summary>
        /// Повертає новий олдноспрямований список який складається з елементів попереднього, які кратні 3
        /// </summary>
        /// <returns></returns>
        SingleLinkedList GetListBy3();
        /// <summary>
        /// Видаляє елементи з списка які менші за середнє значення
        /// </summary>
        void RemoveElementsLessThanAverage();
    }
}
