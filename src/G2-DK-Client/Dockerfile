FROM node:14.2.0-alpine3.11 as build
WORKDIR /src/app

RUN npm install -g @angular/cli

COPY ./package.json .
RUN npm install
COPY . .
RUN ng build

FROM nginx:alpine as runtime
RUN rm -rf /usr/share/nginx/html/*
COPY dist/G2-DK-Client/ /usr/share/nginx/html