using System.Reflection;

namespace Reflexio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reflection();
        }

        private void Reflection()
        {
            List<int> lista = new List<int>();
            lista.Add(12);
            MessageBox.Show(lista.Count + "");
            //MessageBox.Show(lista._size + "");

            Type type = lista.GetType();

            FieldInfo? fieldInfo = type.GetField("_size", BindingFlags.NonPublic | BindingFlags.Instance);
            MessageBox.Show(fieldInfo.GetValue(lista) + "");

            PropertyInfo? propertyInfo = type.GetProperty("System.Collections.IList.IsReadOnly", BindingFlags.NonPublic | BindingFlags.Instance);
            MessageBox.Show(propertyInfo.GetValue(lista) + "");


            MethodInfo? methodInfo = type.GetMethod("Add");
            // add            mire    param.lista   1.paraméter
            methodInfo.Invoke(lista, new object[] { 5 });

            MessageBox.Show(lista.Count + "");

        }
    }
}
