node {
    checkout scm
     stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
    withSonarQubeEnv() {
      bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll begin /k:\"Sonar_test2\""
      bat "dotnet build DockerSQLApp.sln"
      bat "dotnet ${scannerHome}\\SonarScanner.MSBuild.dll end"
    }
  }

    docker.withRegistry('https://243f-89-205-126-247.ngrok.io', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("243f-89-205-126-247.ngrok.io/dockersqlcontainer","-f DockerSqlApp/Dockerfile .")

        /* Push the container to the custom Registry */
        customImage.push("1.1.14")
        
        kubernetesDeploy(configs:"deploymentservice.yml",kubeconfigId:"kubernetes")
    }
}
