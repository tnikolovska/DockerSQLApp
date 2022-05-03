node {
    checkout scm
   

    docker.withRegistry('https://e837-89-205-126-202.ngrok.io', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("e837-89-205-126-202.ngrok.io/dockersqlcontainer","-f DockerSqlApp/Dockerfile .")

        /* Push the container to the custom Registry */
        customImage.push("1.1.21")
        
        kubernetesDeploy(configs:"deploymentservice.yml",kubeconfigId:"kubernetes")
    }
}
