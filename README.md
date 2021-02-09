# ASP.NET app azure deploy

![build test deploy](https://github.com/Arnab-Developer/aspnet-azure-deploy/workflows/build%20test%20deploy/badge.svg)

Deploy ASP.NET app to azure with GitHub action.

## Steps

- Create a new ASP.NET web application.
- Push to GitHub.
- Create a new web app in Azure.
- Download the publish profile from Azure web app.
- Store the publish profile's content to GitHub repository secret.
- Create a workflow with GitHub action to build, test and deploy.

```
- name: 'Deploy to Azure WebApp'
  uses: azure/webapps-deploy@v2
  with:
    app-name: ${{ env.AZURE_WEBAPP_NAME }}
    publish-profile: ${{ secrets.AZURE_WEBAPP_PUBLISH_PROFILE }}
    package: ${{ env.AZURE_WEBAPP_PACKAGE_PATH }}/myapp
```
