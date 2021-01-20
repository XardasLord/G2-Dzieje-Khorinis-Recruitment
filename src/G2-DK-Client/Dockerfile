FROM node:14.2.0-alpine3.11 as build
WORKDIR /app

RUN npm install -g @angular/cli

COPY ./package.json .
RUN npm install
COPY . .
RUN ng build

FROM nginx as runtime
RUN rm -rf /usr/share/nginx/html/*
COPY ./default.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist/G2-DK-Client /usr/share/nginx/html
RUN chown nginx:nginx /usr/share/nginx/html/*