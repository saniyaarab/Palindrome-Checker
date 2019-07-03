<template>
  <v-app id="start">
    <v-content>
      <v-container>
        <v-layout align-center justify-center>
          <v-flex xs12 sm8 md4>
            <v-card class="elevation-12">
              <v-toolbar dark color="primary">
                <v-toolbar-title align-center justify-center>Palindrome Checker</v-toolbar-title>
                <v-spacer></v-spacer>
              </v-toolbar>
              <v-card-text>
                <v-form @submit.prevent="submit"> 
                  <v-text-field v-on:keyup.enter ="submitButtonClick" id="string" prepend-icon="create" name="string" label="Text" type="text" v-model=input.string></v-text-field>
                </v-form>
              </v-card-text>
              <v-card-actions>
                <v-spacer></v-spacer>
                <v-btn color="primary" @click="submitButtonClick" type="submit">Submit</v-btn>
              </v-card-actions>
            </v-card>
             <v-card dark color="green">
              <v-card-text>{{input.answer}}</v-card-text>
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
        string: "",
        answer: ""
      },
      loading: true,
      success: "successfull"
    }),
    methods:{
      submitButtonClick() {
      axios
      .post('CheckIfPalindrome', {
        username: this.input.username, userString: this.input.string
      })
      .then(response => {
        console.log(this.success)
        this.$store.state.userText = this.input.string
        //this.$router.push('./Welcome')
        this.input.answer = response.data
      })
      .catch(error => {
        console.log(error)
      })
      .finally(() => this.loading = false)
    }
    },
  }
</script>