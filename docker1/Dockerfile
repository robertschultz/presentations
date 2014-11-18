# Pull base image from stock node image.
FROM node

# Maintainer
MAINTAINER Robert Schultz <hello@robertschultz.org>

# Add the current working folder as a mapped folder at /usr/src/app
ADD . /usr/src/app

# Set the current working directory to the new mapped folder.
WORKDIR /usr/src/app

# Install the express generator which gives you also scaffolding tools.
RUN npm install -g express-generator

# Scaffold a new express app using hogan.js and less pre-processor.
RUN express -H -f -c less

# Install your application's dependencies
RUN npm install

# Expose the node.js port to the Docker host.
EXPOSE 3000

# This is the stock express binary to start the app.
CMD [ "bin/www" ]
