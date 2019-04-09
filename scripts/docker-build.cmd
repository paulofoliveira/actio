docker build -f ../src/Actio.Api/Dockerfile -t actio.api ../src/Actio.Api
docker build -f ../src/Actio.Services.Activities/Dockerfile -t actio.services.activities ../src/Actio.Services.Activities
docker build -f ../src/Actio.Services.Identity/Dockerfile -t actio.services.identity ../src/Actio.Services.Identity