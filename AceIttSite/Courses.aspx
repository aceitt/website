<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Courses.aspx.cs" Inherits="Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="gt_sub_banner_bg default_width">
        <div class="container">
            <div class="gt_sub_banner_hdg  default_width">
                <h3>Courses Available</h3>
                <ul>
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Courses</a></li>
                </ul>
            </div>
        </div>
    </div>

    <div class="gt_main_content_wrap">
        <!--Course Grid Wrap Start-->
        <section>
            <div class="container">
                <div class="row">
                    <!--Course Grid List Wrap Start-->
                    <div class="col-md-4 col-sm-4">
                        <div class="gt_latest_course2_wrap default_width mb">
                            <figure>
                                <img src="extra-images/latest-course-01.jpg" alt="">
                                <figcaption>
                                    <div class="course_price">$10</div>
                                    <div class="course_category bg_1">Mathematics</div>
                                </figcaption>
                            </figure>
                            <div class="gt_latest_course_des default_width">
                                <h5><a href="#">Vedic Mathematics</a></h5>
                                <p>Teaches ancient Indian Math techniques.<a href="#">Read more</a></p>
                                <div class="gt_latest_course_author">
                                    <figure>
                                        <img src="extra-images/latest-course-author.png" alt="">
                                    </figure>
                                    <div class="course_author_des">
                                        <h6>AceItt LLC</h6>
                                    </div>
                                </div>
                                <div class="gt_course_apply">
                                    <a href="#">Register</a>
                                </div>
                            </div> 
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-4">
                        <div class="gt_latest_course2_wrap default_width mb">
                            <figure>
                                <img src="extra-images/latest-course-02.jpg" alt="">
                                <figcaption>
                                    <div class="course_price">$20</div>
                                    <div class="course_category bg_2">Mathematics</div>
                                </figcaption>
                            </figure>
                            <div class="gt_latest_course_des default_width">
                                <h5><a href="#">Gifted - Grade 2</a></h5>
                                <p>Gifted Test prep for second grade students.<a href="#">Read more</a></p>
                                <div class="gt_latest_course_author">
                                    <figure>
                                        <img src="extra-images/latest-course-author.png" alt="">
                                    </figure>
                                    <div class="course_author_des">
                                        <h6>AceItt LLC</h6>
                                    </div>
                                </div>
                                <div class="gt_course_apply">
                                    <a href="#">Register</a>
                                </div>
                            </div> 
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-4">
                        <div class="gt_latest_course2_wrap default_width mb">
                            <figure>
                                <img src="extra-images/latest-course-03.jpg" alt="">
                                <figcaption>
                                    <div class="course_price">$20</div>
                                    <div class="course_category bg_5">Mathematics</div>
                                </figcaption>
                            </figure>
                            <div class="gt_latest_course_des default_width">
                                <h5><a href="#">Gifted - 3rd grade</a></h5>
                                <p>Gifted test prep for 3rd grade students.<a href="#">Read more</a></p>
                                <div class="gt_latest_course_author">
                                    <figure>
                                        <img src="extra-images/latest-course-author.png" alt="">
                                    </figure>
                                    <div class="course_author_des">
                                        <h6>AceItt LLC</h6>
                                    </div>
                                </div>
                                <div class="gt_course_apply">
                                    <a href="#">Register</a>
                                </div>
                            </div> 
                        </div>
                    </div>
                    
                    <!--Pagination Wrap Start-->
<%--                    <div class="gt_pagination_outer_wrap">
                        <ul>
                            <li><a href="#"><i class="fa fa-angle-double-left"></i></a></li>
                            <li class="active"><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#"><i class="fa fa-angle-double-right"></i></a></li>
                        </ul>
                    </div>--%>
                    <!--Pagination Wrap End-->
                    <!--Course Grid List Wrap End-->
                </div>
            </div>
        </section>
        <!--Course Grid Wrap End-->
    </div>
    <!--Main Content Wrap End-->
    <div id="test" Runat="server"></div>

     <div class="copyright_bg default_width">
            <div class="container">
                <div class="copyright_wrap default_width">
                    <p>©copyrights<a href="#">aceitt.com</a>. All Right Reserved.</p>
                    <span>Designed By: <a href="#">ACEITT LLC</a></span>
                </div>
            </div>
        </div>  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="LeftColumnContent" Runat="Server">
</asp:Content>

