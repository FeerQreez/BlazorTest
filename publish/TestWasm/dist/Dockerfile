FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY . .
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80
