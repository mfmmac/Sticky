using StickyRegistration.Models;

namespace StickyRegistration.Services
{
    public interface IStickyService
    {
        StickyRegistrationResultViewModel Sticky(StickyRegistrationViewModel viewModel);
    }

    public class StickyService : IStickyService
    {
        public StickyRegistrationResultViewModel Sticky(StickyRegistrationViewModel viewModel)
        {
            return new StickyRegistrationResultViewModel
            {
                Title = viewModel.Title,
                Category = viewModel.Category,
                Description = viewModel.Description,
                Address = viewModel.Address,
                Name = viewModel.Name,
                Result = viewModel.Title + " has been registered."
            };
        }
    }
}
