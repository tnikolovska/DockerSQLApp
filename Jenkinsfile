node {
    checkout scm

    docker.withRegistry('https://6032-89-205-126-202.ngrok.io', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("6032-89-205-126-202.ngrok.io/dockersqlcontainer","-f DockerSqlApp/Dockerfile .")

        /* Push the container to the custom Registry */
        customImage.push("1.0.3")
        
        kubernetesDeploy(configs:"deploymentservice.yml",kubeconfigId:"kubernetes")
    }
}
