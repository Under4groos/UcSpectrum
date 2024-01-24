using System.ComponentModel;
using SpectrumAnalyzer.Models;
 
namespace UcSpectrum.Singleton
{
    public class ViewModelLocator
    {
      

        private static ViewModelLocator _instance;

        public static ViewModelLocator Instance
        {
            get
            {
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return null;
                return _instance ?? (_instance = new ViewModelLocator());
            }
        }
 

        private AnalyzerViewModel _analyzerViewModel;

        public AnalyzerViewModel AnalyzerViewModel => _analyzerViewModel 
            ?? (_analyzerViewModel = 
                new AnalyzerViewModel(
                    UcSpectrum.Properties.Settings.Default.Bins,
                    UcSpectrum.Properties.Settings.Default.Rate,
                    UcSpectrum.Properties.Settings.Default.Normal));
    }
}