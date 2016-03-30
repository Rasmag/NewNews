using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Prism.Mef;

namespace NewNews
{
	public class Bootstrapper:MefBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return this.Container.GetExportedValue<MainWindow>();
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();
			Application.Current.MainWindow = (Window)this.Shell;
			Application.Current.MainWindow.Show();
		}

		protected override void ConfigureAggregateCatalog()
		{
			this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(this.GetType().Assembly));
		}
	}
}
