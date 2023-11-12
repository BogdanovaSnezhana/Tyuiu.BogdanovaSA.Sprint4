using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint4.Task6.V19.Lib;

namespace Tyuiu.BogdanovaSA.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
       
            [TestMethod]
            public void ValidCalc()
            {
                DataService ds = new DataService();

                CollectionAssert.AreEqual(new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" }, ds.Calculate(new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "фиолетовый" }));
            }
        
    }
}
