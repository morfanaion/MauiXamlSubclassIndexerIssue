using TestCompiledBindings.Models;

namespace TestCompiledBindings.ViewModels
{
    internal class ViewModel
    {
        private RealModel? _model;
        public BaseModel BaseModel => RealModel;
        public RealModel RealModel => _model ??= new RealModel();
    }
}
