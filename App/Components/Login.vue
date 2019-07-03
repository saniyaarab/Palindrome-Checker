<template>
  <v-app id="login">
    <v-content>
      <v-container >
        <v-layout align-center justify-center>
          <v-flex xs12 sm8 md4>
            <v-card class="elevation-12">
              <v-toolbar dark color="primary">
                <v-toolbar-title align-center justify-center>Login</v-toolbar-title>
                <v-spacer></v-spacer>
              </v-toolbar>
              <v-card-text>
                <v-form>
                  <v-text-field prepend-icon="person" name="login" label="Login" type="text" v-model=input.username></v-text-field>
                  <v-text-field id="password" prepend-icon="lock" name="password" label="Password" type="password" v-model=input.password></v-text-field>
                </v-form>
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="primary" @click="loginButtonClick">Login</v-btn>
              </v-card-actions>
            </v-card>
          </v-flex>
        </v-layout>
      </v-container>
    </v-content>
  </v-app>
</template>

<script>
import axios from 'axios';

  export default {
    data: () => ({
      input:{
        username: "",
        password: ""
      },
      loading: true,
      success: "Login was successfull"
    }),
    methods:{
      loginButtonClick() {
      axios
      .post('Account', {
        username: this.input.username, password: this.input.password
      })
      .then(response => {
        console.log(this.success)
        this.$store.state.username = this.input.username
        this.$router.push('./Welcome')
      })
      .catch(error => {
        console.log(error)
      })
      .finally(() => this.loading = false)
    }
    },
  }
</script>