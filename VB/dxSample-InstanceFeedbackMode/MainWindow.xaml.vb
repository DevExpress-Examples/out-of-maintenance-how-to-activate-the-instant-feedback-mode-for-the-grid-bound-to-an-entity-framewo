Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Data.Linq
Imports DevExpress.Xpf.Grid

Namespace dxSample_InstanceFeedbackMode
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private dataContext As NorthwindEntities
		Public Sub New()
			InitializeComponent()
			dataContext = New NorthwindEntities()
			entitySource.QueryableSource = dataContext.Products
		End Sub
	End Class
End Namespace
