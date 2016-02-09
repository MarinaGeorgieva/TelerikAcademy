namespace WorkingWithRemoteData.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    using Extensions;
    using Helpers;
    using Services;    
    
    public class PopularProjectsViewModel : ViewModelBase
    {
        private BestTAProjectsService projectsService;
        private ObservableCollection<ProjectViewModel> projects;

        private ICommand show;

        public PopularProjectsViewModel()
        {
            this.projectsService = new BestTAProjectsService();
        }

        public ICommand Show
        {
            get
            {
                if (this.show == null)
                {
                    this.show = new RelayCommand(this.GetPopularProjects);
                }

                return this.show;
            }
        }

        public IEnumerable<ProjectViewModel> Projects
        {
            get { return this.projects ?? (this.projects = new ObservableCollection<ProjectViewModel>()); }
            set
            {
                if (this.projects == null)
                {
                    this.projects = new ObservableCollection<ProjectViewModel>();
                }

                this.projects.Clear();

                value.ForEach(this.projects.Add);
            }
        }

        private async void GetPopularProjects()
        {
            var response = await this.projectsService.GetAllProjects();

            response.Projects.ForEach(p =>
            {
                this.projects.Add(new ProjectViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    MainImageUrl = this.GetImageFullUrl(p.MainImageUrl),
                    CreatedOn = p.CreatedOn,
                    ShortDate = p.ShortDate,
                    Likes = p.Likes,
                    Visits = p.Visits,
                    Comments = p.Comments                    
                });
            });
        }        

        private string GetImageFullUrl(string mainUrl)
        {
            return string.Format("http://best.telerikacademy.com/images/{0}_high.jpg", mainUrl);
        }
    }
}
