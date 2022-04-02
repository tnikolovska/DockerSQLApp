node {
    checkout scm

    docker.withRegistry('https://70b9-89-205-126-245.ngrok.io/my-docker-private-registry', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("70b9-89-205-126-245.ngrok.io/my-docker-private-registry/dockersqlcontainer","-f DockerSqlApp/Dockerfile .")

        /* Push the container to the custom Registry */
        customImage.push("1.1.1")
        
        kubernetesDeploy(configs:"deploymentservice.yml",kubeconfigId:"kubernetes")
    }
}
