using System;
using System.Threading.Tasks;

using R5T.F0124;
using R5T.T0131;
using R5T.T0161;
using R5T.T0172;
using R5T.T0181;
using R5T.T0187;


namespace R5T.O0008
{
    [ValuesMarker]
    public partial interface ICodeFileGenerationOperations : IValuesMarker
    {
        public Task Create_AppRazorFile_WebBlazorClient(
            IRazorFilePath razorFilePath)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateAppRazorFile_WebBlazorClient(
                razorFilePath.Value);
        }

        public void Create_AppSettingsJsonFile(
            IJsonFilePath jsonFilePath)
        {
            Instances.TextFileGenerator_F0054.CreateAppSettingsJsonFile(
                jsonFilePath.Value);
        }

        public void Create_Development_AppSettingsJsonFile(
            IJsonFilePath jsonFilePath)
        {
            Instances.TextFileGenerator_F0054.CreateAppSettingsDevelopmentJsonFile(
                jsonFilePath.Value);
        }

        public async Task Create_DocumentationFile(
            ICSharpFilePath csFilePath,
            IProjectDescription projectDescription,
            INamespaceName namespaceName)
        {
            await Instances.CodeFileGenerationOperations_F0083.Create_DocumentationFile(
                csFilePath.Value,
                namespaceName.Value,
                projectDescription.Value);
        }

        public async Task Create_ExampleComponentRazorFile(
            IRazorFilePath razorFilePath,
            INamespaceName namespaceName)
        {
            await Instances.CodeFileGenerationOperations_F0083.CreateExampleComponentRazorFile(
                razorFilePath.Value,
                namespaceName.Value);
        }

        public Task Create_ImportsRazorFile_WebBlazorClient_Components(
            IRazorFilePath razorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateImportsRazorFile_WebBlazorClient_Components(
                razorFilePath.Value,
                projectNamespaceName.Value);
        }

        public Task Create_ImportsRazorFile_WebBlazorClient_ComponentsLayouts(
            IRazorFilePath razorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateImportsRazorFile_WebBlazorClient_ComponentsLayouts(
                razorFilePath.Value,
                projectNamespaceName.Value);
        }

        public Task Create_ImportsRazorFile_WebBlazorClient_Main(
            IRazorFilePath razorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateImportsRazorFile_WebBlazorClient_Main(
                razorFilePath.Value,
                projectNamespaceName.Value);
        }

        public Task Create_ImportsRazorFile_WebBlazorClient_Pages(
            IRazorFilePath razorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateImportsRazorFile_WebBlazorClient_Pages(
                razorFilePath.Value,
                projectNamespaceName.Value);
        }

        public Task Create_PlaceholderHtmlFile(
            IHtmlFilePath htmlFilePath)
        {
            return Instances.TextFileGenerator_F0054.Create_PlaceholderHtmlFile(
                htmlFilePath.Value);
        }

        public Task Create_IndexHtmlFile(
            IHtmlFilePath htmlFilePath,
            string pageTitle)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateIndexHtmlFile(
                htmlFilePath.Value,
                pageTitle);
        }

        public Task Create_IndexHtmlFile_WebBlazorClient(
            IHtmlFilePath htmlFilePath,
            string pageTitle)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateIndexHtmlFile_WebBlazorClient(
                htmlFilePath.Value,
                pageTitle);
        }

        public Task Create_IndexRazorFile_WebBlazorClient(
            IRazorFilePath appRazorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateIndexRazorFile_WebBlazorClient(
                appRazorFilePath.Value,
                projectNamespaceName.Value);
        }

        public void Create_InstancesFile(
            ICodeFilePath codeFilePath,
            INamespaceName namespaceName)
        {
            Instances.CodeFileGenerator_F0053.CreateInstancesFile(
                codeFilePath.Value,
                namespaceName.Value);
        }

        public Task Create_LaunchSettingsJsonFile_WebServerForBlazorClient(
            IJsonFilePath jsonFilePath,
            IProjectName projectName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateLaunchSettings_WebServerForBlazorClient(
                jsonFilePath.Value,
                projectName.Value);
        }

        public Task Create_MainLayoutRazorFile_WebBlazorClient(
            IRazorFilePath layoutRazorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateMainLayoutRazorFile_WebBlazorClient(
                layoutRazorFilePath.Value,
                projectNamespaceName.Value);
        }

        public Task Create_ComponentsLayoutsLayoutRazorFile_WebBlazorClient(
            IRazorFilePath layoutRazorFilePath)
        {
            return Instances.CodeFileGenerationOperations_F0083.Create_ComponentsLayoutsLayoutRazorFile_WebBlazorClient(
                layoutRazorFilePath.Value);
        }

        public Task Create_ComponentsLayoutsLayoutCodeFile_WebBlazorClient(
            IRazorFilePath layoutRazorFilePath,
            INamespaceName projectNamespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.Create_ComponentsLayoutsLayoutCodeFile_WebBlazorClient(
                layoutRazorFilePath.Value,
                projectNamespaceName.Value);
        }

        public Task Create_PackageJsonFile(
            IJsonFilePath jsonFilePath,
            IProjectName projectName,
            IProjectDescription projectDescription)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreatePackageJsonFile(
                jsonFilePath.Value,
                projectName.Value,
                projectDescription.Value);
        }

        /// <inheritdoc cref="O0003.ICodeFileGenerationOperations.Write_ProgramFile_Synchronous(ICSharpFilePath, INamespaceName, FileExistsBehavior)"/>
        public void Create_ProgramFile_ForConsole(
            ICSharpFilePath csfilePath,
            INamespaceName namespaceName)
        {
            Instances.CodeFileGenerationOperations_O0003.Write_ProgramFile_Synchronous(
                csfilePath,
                namespaceName,
                FileExistsBehavior.Overwrite);
        }

        public Task Create_ProgramFile_WebBlazorClient(
            ICSharpFilePath codeFilePath,
            INamespaceName namespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateProgramFile_WebBlazorClient(
                codeFilePath.Value,
                namespaceName.Value);
        }

        public Task Create_ProgramFile_WebServerForBlazorClient(
            ICSharpFilePath codeFilePath,
            INamespaceName namespaceName)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateProgramFile_WebServerForBlazorClient(
                codeFilePath.Value,
                namespaceName.Value);
        }

        public void Create_ProjectPlanFile_Markdown(
            IMarkdownFilePath markdownFilePath,
            IProjectName projectName,
            IProjectDescription projectDescription)
        {
            Instances.TextFileGenerator_F0054.CreateProjectPlanMarkdownFile(
                markdownFilePath.Value,
                projectName.Value,
                projectDescription.Value);
        }

        public Task Create_TailwindConfigJsFile(
            IJsFilePath jsFilePath)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateTailwindConfigJsFile(
                jsFilePath.Value);
        }

        public Task Create_TailwindCssAllContentPathsJsonFile(
            IJsonFilePath jsonFilePath)
        {
            // Initially, just reuse the project's own content paths.
            // A separate script will be required to update all Tailwind CSS content paths.
            return Instances.CodeFileGenerationOperations_F0083.CreateTailwindCssContentPathsJsonFile(
                jsonFilePath.Value);
        }

        public Task Create_TailwindCssContentPathsJsonFile(
            IJsonFilePath jsonFilePath)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateTailwindCssContentPathsJsonFile(
                jsonFilePath.Value);
        }

        public Task Create_TailwindCssFile(
            ICssFilePath cssFilePath)
        {
            return Instances.CodeFileGenerationOperations_F0083.CreateTailwindCssFile(
                cssFilePath.Value);
        }
    }
}
