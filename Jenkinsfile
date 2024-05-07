pipeline {
    agent any
    
    stages {
        stage('Clone project') {
            steps {
                // Clone the repository with branch specified
                git branch: 'main', url: 'https://github.com/dihson103/dotnet-cicd.git'
            }
        }
        // Add more stages as needed
    }
}