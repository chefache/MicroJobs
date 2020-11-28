namespace MicroJobs.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroJobs.Data.Models;

    public class JobsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Jobs.Any())
            {
                return;
            }

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Почистване на апартамент",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 1,
                Description = "Имам нужда от ежеседмично почистване на апартамент в центъра",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 35,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://styx.bg/.data/upload/pics/Novini/uborka31.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobMainCategory = Models.Enums.JobMainCategory.Online,
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://prevodachi.eu/wp-content/uploads/2018/12/prevod-kak-se-pravi-e1544385964394.jpg",
                     },
                },
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Имам нужда от транспорт на покъчнина",
                JobMainCategory = Models.Enums.JobMainCategory.OffLine,
                JobSubCategoryId = 3,
                Description = "Търся бус за транспорт на покъщнина от Пловдив до Шумен",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 122.50M,
                Images = new List<Image>
                {
                     new Image
                     {
                         CreatedOn = DateTime.Now,
                         RemoteImageUrl = "https://hamali-tt.com/wp-content/uploads/2017/01/hamalski-uslugi-plovdiv-hamali-plovdiv-600x377.png",
                     },
                },
            });
            await dbContext.SaveChangesAsync();
        }
    }
}
