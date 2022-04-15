using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SachNoiTrucTuyen.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {   
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            ChangePageCommand = new Command((x) =>
            {
                var page = x as TabbedPage;
                int index = page.Children.IndexOf(page.CurrentPage);
                SetSourceIcon(page, index);

            });
        }
        public void SetSourceIcon(TabbedPage page, int index)
        {
            ImageSource homeSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_hp_1.png");
            ImageSource homeUnSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_hp_0.png");

            ImageSource storySelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_sp_1.png");
            ImageSource storyUnSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_sp_0.png");

            ImageSource knowledgeSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_kp_1.png");
            ImageSource knowledgeUnSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_kp_0.png");

            ImageSource collectionSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_cp_1.png");
            ImageSource collectionUnSelected = ImageSource.FromResource("SachNoiTrucTuyen.Resources.Images.ic_m_cp_0.png");

           
            switch (index)
            {
                case 0: page.Children[index].IconImageSource = homeSelected;
                        page.Children[1].IconImageSource = storyUnSelected;
                        page.Children[2].IconImageSource = knowledgeUnSelected;
                        page.Children[3].IconImageSource = collectionUnSelected;
                        break;
                case 1: page.Children[index].IconImageSource = storySelected;
                        page.Children[0].IconImageSource = homeUnSelected;
                        page.Children[2].IconImageSource = knowledgeUnSelected;
                        page.Children[3].IconImageSource = collectionUnSelected;
                        break;
                case 2: page.Children[index].IconImageSource = knowledgeSelected;
                        page.Children[1].IconImageSource = storyUnSelected;
                        page.Children[0].IconImageSource = homeUnSelected;
                        page.Children[3].IconImageSource = collectionUnSelected;
                        break;
                case 3: page.Children[index].IconImageSource = collectionSelected;
                        page.Children[1].IconImageSource = storyUnSelected;
                        page.Children[2].IconImageSource = knowledgeUnSelected;
                        page.Children[0].IconImageSource = homeUnSelected;
                        break;
                case 4: page.Children[0].IconImageSource = homeUnSelected;
                        page.Children[1].IconImageSource = storyUnSelected;
                        page.Children[2].IconImageSource = knowledgeUnSelected;
                        page.Children[3].IconImageSource = collectionUnSelected;
                        break;
                default: page.Children[index].IconImageSource = homeSelected;
                        page.Children[1].IconImageSource = storyUnSelected;
                        page.Children[2].IconImageSource = knowledgeUnSelected;
                        page.Children[3].IconImageSource = collectionUnSelected;
                        break;
                    
            }
        }
        public Command ChangePageCommand { get; set; }



    }
}
