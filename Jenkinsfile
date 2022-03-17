node {
    checkout scm

    docker.withRegistry('https://83c8-89-205-126-245.ngrok.io:8000/', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("83c8-89-205-126-245.ngrok.io/dockersqlcontainer")

        /* Push the container to the custom Registry */
        customImage.push()
    }
}
