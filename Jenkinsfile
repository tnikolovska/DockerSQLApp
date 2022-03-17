node {
    checkout scm

    docker.withRegistry('http://ff20-89-205-126-202.ngrok.io:8000/', 'daf7ebbe-1b3e-4c81-9e61-b89acae601c3') {

        def customImage = docker.build("8945-89-205-126-202.ngrok.io/dockersqlcontainer")

        /* Push the container to the custom Registry */
        customImage.push()
    }
}
