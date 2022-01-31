FROM mcr.microsoft.com/mssql/server:2019-latest

WORKDIR /app

COPY . .

# Set scripts to be executable. Note that I had to change user for permissions.
USER root
RUN chmod +x ./initialise-sql.sh
RUN chmod +x ./entrypoint.sh
USER mssql

CMD /bin/bash ./entrypoint.sh