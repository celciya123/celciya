import pandas as pd
import seaborn as sns 
import matplotlib.pyplot as plt

df = pd.read_csv("C:/Users\AM Computers/Downloads/top 200 instagrammers.csv")
df.head(4)



df.shape



df.info()


df.describe


df.columns = df.columns.str.replace('.','')
df.head(4)


df.columns = df.columns.str.replace(' ','')
df.head(4)


plt.figure(figsize=(10,8))
sns.countplot(x="Country", data = df)
plt.show()


#Top 10 bloggers name on the basis of like,post and columns.#

new_measures = ['Likes', 'Posts', 'Followers']
for column in new_measures:
    top10 = df.nlargest(10,column)
    plt.figure(figsize=(20,8))
    plt.bar(top10['Username'], top10[column],color='yellow')
    plt.ylabel(column, fontsize = 20)
    plt.xlabel("Name of the influencer", fontsize = 20)
    plt.title("Top 10 Influencers", fontsize = 20)
    plt.xticks(rotation=90,fontsize = 20);



#Now lets find out which country has done the maximum number of post

posts_count_on_country=df.groupby(['Country'],as_index=False)['Posts'].max()
posts_count_on_country.sort_values(['Posts'],inplace=True,ascending=False)
plt.figure(figsize=(16, 8))
plt.title("Top Maximum posts done by person across countries")
ax=sns.barplot(y='Country', x='Posts', data=posts_count_on_country);
plt.show()


Post_count_influencer=df.groupby(['Username'],as_index=False)['Posts'].max()
Post_count_influencer.sort_values(['Posts'],inplace=True,ascending=False)
plt.figure(figsize=(10, 40))
plt.title("Top Maximum posts done by influencer")
ax=sns.barplot(y='Username', x='Posts', data= Post_count_influencer);
plt.show()




#Now lets find out what is the like ratio which is depeniding on the posts for a particular country

plt.figure(figsize=(15, 5))
plt.title("United States")
USA_data=df[df['Country'].isin(["US"])]
sns.lineplot(data=USA_data, x="Posts", y="Likes",hue='Country')
plt.show()


#Also Figure out the relation between follower and like for a specific country.

plt.figure(figsize=(15, 5))
plt.title("INDIA")
India_data=df[df['Country'].isin(["IN"])]
sns.lineplot(data=India_data, x="Followers", y="Likes",hue='Country', color = 'red')
plt.show()



#Checking the ratio of Engagement rate with Respect to Followers

plt.figure(figsize=(15, 5))
sns.scatterplot(x="EngagementRate", y= "Followers", data = df)
plt.title("Followers Vs Engagement Rate")
plt.show()

#Find Out Top 5 influencer with their Followers.

plt.figure(figsize=(8,5 ))
plt.title("Top 5 Influencers with number of followers")
ax=sns.barplot(data=df.head(5), x="Username",y="Followers")
ax.bar_label(ax.containers[0])
plt.xticks(rotation='45',size = '20')

plt.show()




