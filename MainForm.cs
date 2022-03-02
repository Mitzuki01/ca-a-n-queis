/*
 * Created by SharpDevelop.
 * User: Pc
 * Date: 01/03/2022
 * Time: 20:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace caça_niquel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Random rnd= new Random();
		
		void Button1Click(object sender, EventArgs e)
		{
int numero1, numero2, numero3;
numero1= rnd.Next(1,7);
numero2= rnd.Next(1,7);
numero3= rnd.Next(1,7);
//entre parentese deixar o valor minímo e maxímo (o maximo sempre com um numero a mais)

textBox1.Text= numero1.ToString();
textBox2.Text= numero2.ToString();
textBox3.Text= numero3.ToString();

//verifique se os 3 numeros são iguais  = verifique o 1 e o 2, depois compara o 2 com o 3

if(numero1==numero2 && numero1== numero3){
	// cria um alert box
	string message= "Parabéns!!!";
	MessageBox.Show(message);}
	
	
		}
	}
}
