node {
    checkout scm

    docker.withRegistry('https://83c8-89-205-126-245.ngrok.io', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("83c8-89-205-126-245.ngrok.io/dockersqlcontainer","C:\\Users\\nikol\\.jenkins\\workspace\\Jenkins_Pipeline_Upload_Docker_Images\\DockerSqlApp\\Dockerfile")

        /* Push the container to the custom Registry */
        customImage.push()
    }
}
