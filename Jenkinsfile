pipeline {
    agent any
    
    stages {
        stage('Clone project') {
            steps {
                // Clone the repository with branch specified
                git branch: 'main', url: 'https://github.com/dihson103/dotnet-cicd.git'
            }
        }

        stage('Access Jenkins Docker Container') {
            steps {
                script {
                    // Access the Jenkins Docker container and change directory
                    docker.image('jenkins').inside {
                        sh 'cd /var/jenkins_home/workspace/DotnetTestCiCd'
                    }
                }
            }
        }
        
        stage('Run docker compose') {
            steps {
                script {
                    // Run docker-compose
                    sh 'docker-compose up -d'
                }
            }
        }
    }
}
